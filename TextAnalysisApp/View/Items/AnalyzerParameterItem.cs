namespace TextAnalysisApp.View.Items
{
    /// <summary>
    /// Элемент управления для ввода параметра анализатора
    /// </summary>
    public partial class AnalyzerParameterItem : UserControl
    {
        /// <summary>
        /// Возвращает значение параметра
        /// </summary>
        public string Value => textBox.Text;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AnalyzerParameterItem"/>
        /// </summary>
        /// <param name="name"></param>
        public AnalyzerParameterItem(string name)
        {
            InitializeComponent();
            label.Text = name;
        }
    }
}
