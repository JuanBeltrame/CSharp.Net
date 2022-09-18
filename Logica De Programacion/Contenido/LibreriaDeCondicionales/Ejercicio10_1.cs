using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Leer 3 numeros enteros diferentes e imprimir el numero mayor de los tres. 
     */
    #endregion
    public sealed class Ejercicio10_1
    {
        private static void Bievenida()
        {
            Console.WriteLine("Se ingreso al ejercicio {0}", nameof(Ejercicio10_1));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int n1, n2, n3;
            int maximo = 0;

            Console.WriteLine("Ingresar 3 numeros distintos: ");

            string texto1 = Console.ReadLine();
            string texto2 = Console.ReadLine();
            string texto3 = Console.ReadLine();

            n1 = int.Parse(texto1);
            n2 = int.Parse(texto2);
            n3 = int.Parse(texto3);

            if (n1 > n2)
                maximo = n1;
            else
                maximo = n2;
            if (n3 > maximo)
            {
                maximo = n3;
                Console.WriteLine(". El mayor numero de los 3 ingresados es el {0}", maximo);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("El mayor numero de los 3 ingresados es el {0}", maximo);

            }
        }
        private static void Mostrar()
        {
            Bievenida();
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
