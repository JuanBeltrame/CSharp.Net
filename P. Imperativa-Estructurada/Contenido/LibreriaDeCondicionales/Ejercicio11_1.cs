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
        private static void Bievenida()
        {
            Console.WriteLine("Se ingreso al ejercicio {0}", nameof(Ejercicio11_1));
            Console.WriteLine();
        }
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

        private static void CargaYCalculOp2() // Esta forma es mucho mas optima
        {
            string texto1,texto2,texto3,texto4;
            int a, b, c, d;
            int maximo = 0;

            Console.WriteLine("Ingresar 4 numeros enteros distintos: ");
            Console.WriteLine();

            texto1 = Console.ReadLine();
            texto2 = Console.ReadLine();
            texto3 = Console.ReadLine();
            texto4 = Console.ReadLine();

            a = int.Parse(texto1);
            b = int.Parse(texto2);
            c = int.Parse(texto3);
            d = int.Parse(texto4);

            if (a > b)
                maximo = a;
            else
                maximo = b;
            if (c > maximo)
                maximo = c;
            
            if (d > maximo)
                maximo = d;


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
