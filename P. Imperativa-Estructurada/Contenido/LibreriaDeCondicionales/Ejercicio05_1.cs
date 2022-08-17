using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Dados 2 numeros enteros distintos, encontrar e informar cual es el mayor.
     */
    #endregion
    public class Ejercicio05_1
    {
        private static void CargaYCalculo()
        {
            int num1, num2;
            int mayor = 0;
            
            Console.WriteLine("Ingrese 2 numeros: ");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros no deben ser iguales");
            }
            else if (num1 > num2)
            {
                mayor = num1;
                Console.WriteLine("El numero mas grande de los dos es el: {0}",mayor);
            }
            else
            {
                mayor = num2;
                Console.WriteLine("El numero mas grande de los dos es el {0}",mayor);
            }
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
