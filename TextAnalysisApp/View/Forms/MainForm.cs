using TextAnalysisApp.Exceptions;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.View.Forms
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция элементов анализаторов
        /// </summary>
        private readonly List<AnalyzerItem> items;

        /// <summary>
        /// Текст для анализа
        /// </summary>
        private string text;

        /// <summary>
        /// Путь к файлу, текст которого необходимо анализировать
        /// </summary>
        private string fileName;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            items = AnalyzerFactory.CreateAnalyzerItems();
        }

        /// <summary>
        /// Обрабатывает событие загрузки формы
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Объект, содержащий данные о событии</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ListControl analyzersListControl = analyzersListBox;
            analyzersListControl.DataSource = items;
            analyzersListControl.DisplayMember = "Name";
        }

        /// <summary>
        /// Обрабатывает событие при изменении выбранного анализатора в списке
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Объект, содержащий данные о событии</param>
        private void analysesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            analysisParametersPanel.Controls.Clear();
            analysisParametersPanel.Controls.AddRange(items[analyzersListBox.SelectedIndex].AnalyzerParameterItems.ToArray());
        }

        /// <summary>
        /// Обрабатывает событие при нажатии на кнопку анализа
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Объект, содержащий данные о событии</param>
        private void analyzeButton_Click(object sender, EventArgs e)
        {
            resultsListView.Items.Clear();
            foreach (var checkedItem in analyzersListBox.CheckedItems)
            {
                try
                {
                    AnalysisResult result = (checkedItem as AnalyzerItem).ExecuteAnalysis(text);
                    resultsListView.Items.Add(new ListViewItem(new string[] { result.Name, result.Value }));
                }
                catch (AnalyzerException exception)
                {
                    resultsListView.Items.Clear();
                    analyzersListBox.SelectedIndex = analyzersListBox.Items.IndexOf(checkedItem);
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }


        /// <summary>
        /// Обрабатывает событие при нажатии на кнопку загрузки файла
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Объект, содержащий данные о событии</param>
        private void loadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                text = TextFileReader.ReadFile(fileName);
                analyzeButton.Enabled = true;
            }
        }
    }
}
