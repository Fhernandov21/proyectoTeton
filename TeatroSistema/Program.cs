    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroSistema.View;
namespace TeatroSistema
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmVentas()) ;
=======
            Application.Run(new frmAddPersona(1)) ;
>>>>>>> 9fa82d843e6eadb5e060c1a6f331a5a3a02675d7
        }
    }
}
