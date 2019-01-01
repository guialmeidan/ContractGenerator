using Principal.Infra;
using Principal.WinApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using System.Globalization;
using System.IO.Compression;
using System.IO;
using DevExpress.Skins;
using Principal.Forms;

namespace Principal
{
    static class ConsoleApplication1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableMdiFormSkins();
            SkinManager.EnableFormSkins();
            AppCore.Start();
            RunMigration();

            //parte nova
            var mdiForm = new Principal();
            //App.Init(mdiForm);
            Application.Run(mdiForm);


            //Application.Run(new Login());            
        }

        private static void RunMigration()
        {
            var migration = AppCore.Container.Resolve<IMigrationWinAppRunner>();
            migration.Execute();
        }

    }
}
