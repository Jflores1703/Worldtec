using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProducto { get; set; }

        public ProductosBL()
        {

            ListaProducto = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Monitor LCD";
            producto1.Precio = 10000;
            producto1.Existencia = 20;
            producto1.Activo = true;

            ListaProducto.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Teclado Gamer";
            producto2.Precio = 1000;
            producto2.Existencia = 20;
            producto2.Activo = true;

            ListaProducto.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Camara Web";
            producto3.Precio = 1200;
            producto3.Existencia = 10;
            producto3.Activo = true;

            ListaProducto.Add(producto3);

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Mouse Led";
            producto4.Precio = 300;
            producto4.Existencia = 15;
            producto4.Activo = true;

            ListaProducto.Add(producto4);
        }

        public BindingList<Producto> ObtenerProducto()
        {
            return ListaProducto;
        }
        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso==false) {
                return resultado;
            }
            if (producto.Id == 0)
            {
                producto.Id = ListaProducto.Max(item => item.Id) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarProducto()
        {
            var NuevoProducto = new Producto();
            ListaProducto.Add(NuevoProducto);

        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProducto)
            {
                if (producto.Id == id)
                {
                    ListaProducto.Remove(producto);
                    return true;

                }
            }
            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
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
            return resultado;
        }
        public class Producto
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public bool Activo { get; set; }

        }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }

        
    }

}



