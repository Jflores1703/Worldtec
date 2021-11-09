using System;
using System.Data.Entity;

namespace BL.Tecnologia
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var Categoria1 = new Categoria();
            Categoria1.Descripcion = "Laptop";
            contexto.Categorias.Add(Categoria1);

            var Categoria2 = new Categoria();
            Categoria2.Descripcion = "Celular";
            contexto.Categorias.Add(Categoria2);

            var Categoria3 = new Categoria();
            Categoria3.Descripcion = "Accesorios";
            contexto.Categorias.Add(Categoria3);

            var cliente1 = new Cliente();
            cliente1.Nombre = "Josian Flores";
            cliente1.RTN = "03111";
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "Kenia Bueso";
            cliente2.RTN = "00787";
            contexto.Clientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Nombre = "Xavier Castillo";
            cliente3.RTN = "25672";
            contexto.Clientes.Add(cliente3);

            base.Seed(contexto);
        }
    }
}
