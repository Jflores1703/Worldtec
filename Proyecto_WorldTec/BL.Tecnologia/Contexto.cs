
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using static BL.Tecnologia.ProductosBL;

namespace BL.Tecnologia
{
    public class Contexto:DbContext
    {
        public Contexto() : base("POS_L3")
        {}

        //Elimina la pluralización en la creación de las tablas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Producto> Productos { get; set; }
    }
}

