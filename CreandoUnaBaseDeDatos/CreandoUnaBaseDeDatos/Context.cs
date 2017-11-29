using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreandoUnaBaseDeDatos
{
    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().Property(c => c.Name).IsRequired().HasColumnName("Name2").HasMaxLength(50);
            modelBuilder.Entity<City>().HasKey(c => c.Id);
            modelBuilder.Entity<Employee>().HasKey(c => c.Id);
            modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<Employee>().HasOptional(c => c.Supervisor);

            modelBuilder.Entity<Employee>().HasRequired(c => c.City).WithMany(c => c.Employees);//Un empleado tiene una ciudad y una ciudad tiene muchos empleados  
            base.OnModelCreating(modelBuilder);
        }
    }
}
//Para buscar lo de app config. propiedades de la base de datos. copio cadena de conexcion en connectionString-providerName="System.Data.SQLClient"
/* En consola
-> enable-migrations
-> add-migration 'nombre que le quiero poner a la migracion'
-> update-database //crea las tablas de las migraciones 
-> udate-database -targetMigration: Test2 // Volves atras hasta la migracion que elijas- lineal
-> udate-database -Script: SourseMigration: InitialMigration //Inicia las migraciones
*/
