﻿using Dominio;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Datos
{
    public class Modelo : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Modelo' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Datos.Modelo' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Modelo'  en el archivo de configuración de la aplicación.
        public Modelo()
            : base("Sistema")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();
            

            //modelBuilder.Entity<Operacion_Detalle>()
            //    .HasKey(x => x.ID);                


            modelBuilder.Entity<Operacion>()
                .HasKey(x => x.ID_Operacion);

            modelBuilder.Entity<Articulo>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Caja>()
                .HasKey(x => x.IdCaja);

            modelBuilder.Entity<Categoria>()
                .HasKey(x => x.Id);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Articulo> Articulos { get; set; }

       public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Operacion> operaciones { get; set; }

        public DbSet<Detalle> Detalle { get; set; }

        public DbSet<Caja> Cajas { get; set; }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}