using System.Linq;
using System.Collections.Generic;

namespace BL.Tecnologia
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public List<Usuario> Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();
            return usuarios;
        }
    }
}