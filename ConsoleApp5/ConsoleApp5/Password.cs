﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{/*
    Crear una clase Password la cual tendra dos variables,
clave y longitud.

La longitud es opcional por defecto 8, generar un constructor que cumpla esto.

La clave no debe ser visible exteriormente.

Generar los metodos 

EsFuerte() que devuelve un bool si la clave interna contiene al menos 1 numero y una mayuscula

Clave(bool generar) que devuelve la clave y toma un bool que indica si debe debe regenerar la clave con 
la longitud interna y luego devuelve la clave.

Generar propiedad para longitud, (validar que sea una longitud valida > 0)

Crear una app de consola que permita el ingreso al usuario de una longitud para su generador de password y 
que el sistema le permita las siguientes operaciones
 - Si ingresa 'e' indicar si su clave es fuerte o 'No tiene clave' si aun no la genero

 - Si ingresa 'c' se debe preguntar si se desea generar nuevamente con 's' o 'n' ( Pedir dato hasta que sea 
 correcto) y luego mostrar la clave

 - Si ingresa 'f' - Finalizar el sistema

 Pedir operaciones hasta que el usuario ingrese f.
     */

    class Password
    {
        private string clave;
        private int longitud;


        public Password(int longitud = 8)
        {
                
        }

        public bool EsFuerte(string clave)
        {

            foreach(char n in clave)
            {
                if(Char.IsUpper(n) || Char.IsNumber(n))
                {
                    return true;
                }

                return false;
                

            }
            
        }

        public string Clave (bool generar)
        {

            return clave;
        }
    }
}
