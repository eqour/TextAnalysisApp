using System.Windows.Forms;

namespace TextAnalysisApp.View.Items
{
    public partial class AnalyzerParameterItem : UserControl
    {
        public string Value => textBox.Text;

        public AnalyzerParameterItem(string name)
        {
            InitializeComponent();
            label.Text = name;
        }
    }
}
