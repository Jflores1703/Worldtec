using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace BL.Tecnologia
{
    public class UsuarioBL
    {
        Contexto _contexto;
        public BindingList<Usuario> ListaUsuarios { get; set; }
        public UsuarioBL()
        {
            //Se instancia la variable _contexto en del tipo Contexto
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Tipo { get; set; }
        public bool CambiarContrasena { get; set; }

        public Usuario()
        {
            CambiarContrasena = false;
        }
    }
}
