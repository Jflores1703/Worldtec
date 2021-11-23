using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WorldTec
{
    public static class Utilidades
    {

        public static FormMenuPrincipal frmmenu = new FormMenuPrincipal();
        public static FormLogin frmlogin = new FormLogin();
        public static string UsuarioStatus;

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
}
