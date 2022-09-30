using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TextApp.Model;

namespace TextApp.View.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<AnalyzerItem> items;
        private string text;

        public MainForm()
        {
            InitializeComponent();
            items = AnalyzerFactory.createAnalyzerItems();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ListControl analyzersListControl = analyzersListBox;
            analyzersListControl.DataSource = items;
            analyzersListControl.DisplayMember = "Name";
        }

        private void analysesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            analysisParametersPanel.Controls.Clear();
            analysisParametersPanel.Controls.AddRange(items[analyzersListBox.SelectedIndex].AnalyzerParameterItems.ToArray());
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            resultsListView.Items.Clear();
            foreach (var checkedItem in analyzersListBox.CheckedItems)
            {
                AnalysisResult result = (checkedItem as AnalyzerItem).ExecuteAnalysis(text);
                resultsListView.Items.Add(new ListViewItem(new string[] { result.Name, result.Value }));
            }
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            analyzeButton_Click(sender, e);
            text = ""; // todo: реализовать загрузку текста из файла
        }
    }
}
