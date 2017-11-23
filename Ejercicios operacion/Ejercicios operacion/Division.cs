using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_operacion
{
    class Division : Operacion
    {
        public Division()
        {

        }

        public override decimal Operar()
        {
            return this.valor1 / this.valor2;
        }
    }
}
