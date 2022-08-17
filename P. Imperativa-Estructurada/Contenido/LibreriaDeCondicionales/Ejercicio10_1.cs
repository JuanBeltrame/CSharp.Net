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
    public class Ejercicio10_1
    {
        private static void CargaYCalculo()
        {
            int n1, n2, n3;
            int maximo = 0;

            Console.WriteLine("Ingresar 3 numeros distintos: ");

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
                maximo = n1;
            else
                maximo = n2;
            if (n3 > maximo)
                maximo = n3;
            else
            {

            }
            Console.WriteLine("El mayor numero de los 3 ingresados es el {0}", maximo);
        }
        private static void Mostrar()
        {
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
