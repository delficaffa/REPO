using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreandoUnaBaseDeDatos.Configuraciones
{
    class CityConfigurations : EntityTypeConfiguration<City>
    {
        // AGREGO LAS CONFIGURACIONES QUE QUIERA DE CIUDAD
    }
    // EN CONTEXT modelBuilder.Configurations.Add(new CityConfigurations());
    // EN CONTEXT modelBuilder.Configurations.AddFromAssembly(typeof(Context).Assembly);
    // Va a buscar todas las clases que hereden EntityTypeConfiguration
}
