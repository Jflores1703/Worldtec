using System.ComponentModel;
using System.Data.Entity;

namespace BL.Tecnologia
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();
            return ListaClientes;
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarCliente()
        {
            var NuevoCliente = new Cliente();
            ListaClientes.Add(NuevoCliente);

        }
        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;

                }
            }
            return false;
        }
        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if (cliente == null)
            {
                resultado.Mensaje = "Agregue un Cliente válido";
                resultado.Exitoso = false;
                return resultado;
            }

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            return resultado;
        }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }

    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RTN { get; set; }
        public bool Activo { get; set; }
    }

}



