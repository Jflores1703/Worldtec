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
            if (usuario == "admin" && contrasena == "admin")
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
