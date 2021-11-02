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

            base.Seed(contexto);
        }
    }
}
