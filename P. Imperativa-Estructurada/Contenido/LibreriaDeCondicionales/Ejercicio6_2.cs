using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado 
    /*
     Haer un programa para ingresar 2 numeros enteros y que luego emita por pantalla el mayor de ellos
    o un cartel aclaratorio "Son Iguales" en el caso de que asi sea. 
    Indicar la cantidad de numeros ingresados. 
     */
    #endregion
    public class Ejercicio6_2
    {
        private static void CargaYCalculo()
        {
            int num1;
            int num2;
            int contador = 0;

            Console.WriteLine("Ingresar 2 numeros: ");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            contador++;
            contador += 1;

            if (num1 == num2)
            {
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine($"Los numeros {num1} y {num2} ingresados son iguales");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El numero {0} es el mayor de los 2", num1);
            }
            else
            {
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El numero {0} es el mayor de los 2", num2);
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
