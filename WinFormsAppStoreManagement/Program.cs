using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppStoreManagement.UserInterface.MainForms;

namespace WinFormsAppStoreManagement
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin formLogin = new FormLogin();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMainMenu(formLogin.LoginAccount));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
