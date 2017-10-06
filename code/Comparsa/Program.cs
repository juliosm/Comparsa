using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Comparsa
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool dbConnected = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppUtils.InitializeGlobals();

            dbConnected = AppUtils.InitializeDBConnection();

            if (dbConnected)
            {
                Application.Run(new frmMain());
            }

        }

    }

}
