using System.Windows.Forms;

namespace TextApp.View.Items
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
