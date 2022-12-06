using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese_tuning
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLoading load = new FormLoading();
            load.Show();
            load.Update();
            System.Threading.Thread.Sleep(1000);
            load.Close();
            Application.Run(new PassLogForm());
        }
    }
}
