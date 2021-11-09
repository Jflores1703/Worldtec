using System.ComponentModel;
using System.Data.Entity;

namespace BL.Tecnologia
{
    public class ProductosBL
    {
        Contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            //Se instancia la variable _contexto en del tipo Contexto
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();
        }

        public BindingList<Producto> ObtenerProducto()
        {   
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }
        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if (resultado.Exitoso==false) {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarProducto()
        {
            var NuevoProducto = new Producto();
            ListaProductos.Add(NuevoProducto);

        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;

                }
            }
            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (producto == null)
            {
                resultado.Mensaje = "Agregue un producto válido";
                resultado.Exitoso = false;
                return resultado;
            }
            if (string.IsNullOrEmpty(producto.Descripcion)==true)
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false;
            }
            if (producto.Existencia <= 0)
            {
                resultado.Mensaje = "La exitencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            if (producto.Precio <= 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            if (producto.CategoriaId==0) 
            {
                resultado.Mensaje = "Seleccione una categoria";
                resultado.Exitoso = false;
            }
            return resultado;
        }
        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }

        public class Producto
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public int CategoriaId { get; set; }
            public Categoria Categoria { get; set; }
            public byte[] Foto { get; set; }
            public bool Activo { get; set; }

            public Producto()
            {
                Activo = true;
            }

        }
    }

   

}



