using System;

namespace Accounts_Holder
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // При запуске приложения создать контроллер и запустить авторизацию
            Sys.AppCtrl = new Controller.AppController();
            Sys.AppCtrl.Login();
        }
    }
}