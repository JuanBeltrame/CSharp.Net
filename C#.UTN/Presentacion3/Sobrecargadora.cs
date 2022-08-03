using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion3
{
    internal class Sobrecargadora
    {
        public static int Sumar(int operando1, int operando2)
        {
            return operando1 + operando2;
        }

        public static int Sumar(int operando1, int operando2, int operando3)
        {
            return operando1 + operando2 + operando3;
        }


        public static string Concatenar(string cadena1, string cadena2)
        {
            return $"Esta es la primer cadena {cadena1} y esta es la segunda cadena {cadena2}";
        }

        public static string Concatenar(string cadena1, string cadena2, int numero)
        {
            return $"Esta es la primer cadena {cadena1} y esta es la segunda cadena {cadena2}, y le agregamos un numero {numero}";
        }        
    }
}
