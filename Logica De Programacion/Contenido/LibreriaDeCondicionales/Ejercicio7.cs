using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Hacer un programa para ingresar cuatro numeros de tipo entero 
    y luego mostrar por pantalla cuales mayores a 100 
    */
    #endregion
    public class Ejercicio7
    {
        private static int CargaYCalculo()
        {
            int n1, n2, n3, n4;
            int contador = 0;

            Console.WriteLine("Ingresar 4 numeros:");
            n1 = int.Parse(Console.ReadLine());
            if (n1 > 100)
                contador++;
            else
            {

            }

            n2 = int.Parse(Console.ReadLine());
            if (n2 > 100)
                contador++;
            else
            {

            }

            n3 = int.Parse(Console.ReadLine());
            if (n3 > 100)
                contador++;
            else
            { 

            }

            n4 = int.Parse(Console.ReadLine());
            if (n4 > 100)
                contador++;
            else
            {

            }

            return contador;
        }
        private static void Mostrar()
        {
            Console.WriteLine("Los numeros mayores a 100 han sido: {0}",CargaYCalculo());
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
