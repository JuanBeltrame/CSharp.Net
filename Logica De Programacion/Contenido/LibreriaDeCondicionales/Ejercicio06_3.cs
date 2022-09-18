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
    Indicar la cantidad de numeros ingresados y finalmente guardar los valores ingresados en un acumulador
    e indicar el valor final del acumulador. 
     */
    #endregion
    public sealed class Ejercicio06_3
    {
        private static void CargaYCalculo()
        {
            int num1;
            int num2;
            int contador = 0;
            int acumulador = 0;
            int maximo = 0;

            Console.WriteLine("Ingresar 2 numeros: ");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            contador++;
            contador += 1;
            acumulador = num1 + num2;

            if (num1 == num2)
            {
                Console.WriteLine($"Los numeros {num1} y {num2} ingresados son iguales");
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El valor acumulado en el acumulador es: "+acumulador);
            }
            else if (num1 > num2)
            {
                maximo = num1; 
                Console.WriteLine("El numero {0} es el mayor de los 2", maximo);
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El valor acumulado en el acumulador es: " + acumulador);
            }
            else
            {
                maximo = num2;
                Console.WriteLine("El numero {0} es el mayor de los 2", maximo);
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El valor acumulado en el acumulador es: " + acumulador);
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
