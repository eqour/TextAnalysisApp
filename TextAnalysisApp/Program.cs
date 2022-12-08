using TextAnalysisApp.View.Forms;

namespace TextAnalysisApp
{
    /// <summary>
    /// Содержит точку входа в приложение
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  Главная точка входа в приложение
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}