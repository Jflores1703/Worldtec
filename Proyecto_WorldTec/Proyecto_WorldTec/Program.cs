using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_WorldTec
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
            //Application.Run(new FormLogin());
            mostrarLogin();
            Application.Run();
        }
        public static void mostrarLogin()
        {
            Utilidades.showLogin();
        }
        public static void mostrarMenu()
        {
            Utilidades.showMenu();
        }
        public static byte[] imageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }

    }
    
}
