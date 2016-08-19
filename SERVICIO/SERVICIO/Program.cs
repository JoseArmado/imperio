using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //conexion
            string ds = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Servicio-Social/SERVICIO/SERVICIO/baseseguro.mdb";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(ds));
        }
    }
}
