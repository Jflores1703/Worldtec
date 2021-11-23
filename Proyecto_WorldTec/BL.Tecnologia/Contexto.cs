using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using static BL.Tecnologia.ProductosBL;

namespace BL.Tecnologia
{
    public class Contexto:DbContext
    {
        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\LP3\POS_L3.mdf")
        { }

        //Elimina la pluralización en la creación de las tablas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}


