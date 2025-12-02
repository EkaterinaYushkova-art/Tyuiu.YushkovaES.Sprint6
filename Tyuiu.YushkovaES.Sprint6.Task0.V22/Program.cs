using System;
using System.Windows.Forms;

namespace Tyuiu.YushkovaES.Sprint6.Task0.V22
{
    internal static class Program
    {
        /// <summary>
        ///  Главная точка входа в приложение.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}