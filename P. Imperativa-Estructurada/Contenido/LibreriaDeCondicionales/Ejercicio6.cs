using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Hacer un programa para ingresar cuatro numeros enteros distintos y luego mostrar por pantalla el menor de ellos. 
    */
    #endregion
    public class Ejercicio6
    {
        private static int CargaYCalculo()
        {
            int num1, num2, num3, num4;
            int minimo = 1000;

            Console.WriteLine("Ingrese cuatro numeros distintos:");

            num1 = int.Parse(Console.ReadLine());
            if (num1 < minimo)
                minimo = num1;

            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Los numeros ingresados deber ser distintos");
            else if (num2 < minimo)
                minimo = num2;

            num3 = int.Parse(Console.ReadLine());
            if (num3 == num1 || num3 == num2)
                Console.WriteLine("Los numeros ingresados deber ser distintos");
            else if (num3 < minimo)
                minimo = num3;

            num4 = int.Parse(Console.ReadLine());
            if (num4 == num1 || num4 == num2 || num4 == num3)
            {
                Console.WriteLine("Los numeros ingresados deber ser distintos");
                return -1;
            }
                
            else if (num4 < minimo)
            {
                minimo = num4;
                return minimo;
            }
            else
                return minimo;    
        }
        private static void Mostrar()
        {
            Console.WriteLine("El numero menor ingresado ha sido el: {0}",CargaYCalculo());
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
