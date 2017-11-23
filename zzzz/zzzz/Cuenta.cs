using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzzz
{/*
    *
    Crea una clase llamada cuenta que tendra los siguientes atibutos: titular y cantidad (puede tener decimales)
    
    el titular sera obligatorio y la cantidad es opcional
    crea dos contructores que cumpla lo anterior

    crea sus propiedades

    tendras dos metodos especiales:
    ingresar (decimal cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, 
    no se hara nada.
    retirar(decimal cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos 
    pasan es negativa, la cantidad de la cuenta pasa a ser 0
     *     
     */
    class Cuenta
    {
        private string Titular { get; set; }
        private decimal Cantidad { get; set; }

       

        public Cuenta(string titular, decimal cantidad)
            : this(titular)
        {
            Titular = titular;
            Cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
                     
        }

        public void ingresar(decimal cant)
        {
            while (cant > 0)
            {
                Cantidad += cant;
            }

        }
        public void retirar(decimal cant)
        {
            Cantidad -= cant;
            if ( Cantidad < 0)
            {
                Cantidad = 0;
            }
            
        }
        public decimal mostrar(Cuenta c)
        {
            return Cantidad;
         }

    }
}
