using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TP1POO
{
    public abstract class Empleados
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int AnioIngreso { get; set; }
        public int Dni { get; set; }
        public int PrecioPorHora { get; set; }
        public int CantidadHorasTrabajadas { get; set; }

        public abstract int SueldoBase {get;}
        public int Antiguedad(DateTime hoy)
        {
            return this.AnioIngreso - hoy.Year; //PONER QU EPASA SI ES NEGATIVA
        }
    }
}
