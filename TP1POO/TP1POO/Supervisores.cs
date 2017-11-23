using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    class Supervisores : Empleados
    {
        public override int SueldoBase => 4000;
    }

    class Vendedores : Empleados
    {
        public override int SueldoBase => 2000;
    }


}
