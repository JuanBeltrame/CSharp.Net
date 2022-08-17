using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    public class Ejercicio11_1
    {
        #region Enunciado
        /*
        Hacer un programa para ingresar 4 numeros distintos
        y luego mostrar el Mayor de ellos. 
         */

        #endregion
        private static void CargaYCalculoOp1()
        {
            int num1, num2, num3, num4;
            int maximo = 0;

            Console.WriteLine("Ingresar 4 numeros enteros distintos: ");
            Console.WriteLine();

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                maximo = num1;
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                maximo = num2;
            }
            else if (num3 > num1 && num3 > num4 && num3 > num4)
            {
                maximo = num3;
            }
            else
            {
                maximo = num4;
            }
        }

        private static void CargaYCalculOp2()
        {
            int a, b, c, d;
            int maximo = 0;

            Console.WriteLine("Ingresar 4 numeros enteros distintos: ");
            Console.WriteLine();

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if (a > b)
                maximo = a;
            else
                maximo = b;
            if (c > maximo)
                maximo = c;
            else
            {

            }

            if (d > maximo)
                maximo = d;
            else
            {

            }

            Console.WriteLine("El numero ingresado de mayor valor fue el {0}", maximo);
        }
        private static void Mostrar()
        {
            CargaYCalculOp2();
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
