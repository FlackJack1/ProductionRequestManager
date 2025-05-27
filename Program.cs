using System;
using System.Windows.Forms;

namespace ProductionRequestManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка запуска: {ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

