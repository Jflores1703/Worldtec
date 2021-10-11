using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class SeguridadBL
    {
       public bool Autorizar( string usuario, string contrasena)
        {
            if (usuario == "Admin21" && contrasena == "unahvs" || (usuario == "Jonathan Sandoval" && contrasena == "jona123") || (usuario == "Carlos Fernandez" && contrasena == "carlos123"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

    }
}
