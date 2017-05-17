using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

namespace SYSLAB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-SV");

            string cnConfiguracion = @"Data Source=.\SQLEXPRESS;" +
                                        "Initial Catalog=syslab;"+
                                        "Persist Security Info=True;"+
                                        "User ID=sa;Password=123456";

            Properties.Settings.Default.syslabConnectionString = cnConfiguracion;
            ConfigurationManager.RefreshSection("connectionStrings");

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();
            ps.CerrarConexion();
            ps = null;

            Application.Run(new frmPrincipal());
        }
    }
}
