using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_WorldTec
{
    public static class Pantallas
    {
        public static FormMenuPrincipal frmmenu = new FormMenuPrincipal();
        public static FormLogin frmlogin = new FormLogin();

        public static void showLogin()
        {
            frmlogin.Show();
            frmmenu.Hide();
        }

        public static void showMenu()
        {
            frmlogin.Hide();
            frmmenu.Show();
        }

    }
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
            Pantallas.showLogin();
        }
        public static void mostrarMenu()
        {
            Pantallas.showMenu();
        }
        public static byte[] imageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }

    }
    
}
