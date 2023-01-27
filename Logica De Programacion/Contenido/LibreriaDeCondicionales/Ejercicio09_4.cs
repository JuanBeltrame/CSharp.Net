using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado

    // Hacer un programa para ingresar dos números distintos enteros y luego se muestre por pantalla el menor de ellos.
    // Indicar la cantidad de números ingresados
    // Determinar si los números ingresos son positivos o negativos.
    // Guardar los valores de los números ingresados en un acumulador e indicar el valor final del mismo.

    #endregion
    public sealed class Ejercicio09_4
    {

        // Metodos |
        private static void Bienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se ingreso al ejercicio: {0}", nameof(Ejercicio09_4));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        private static void CargayCalculo()
        {
            sbyte num1 = 0;
            sbyte num2 = 0;
            sbyte menor = 0;
            byte contador = 0;
            sbyte acumulador = 0;

            Console.WriteLine("Ingrese 2 numeros distintos");

            string texto1 = Console.ReadLine();
            num1 = sbyte.Parse(texto1);
            contador++;
            if (num1 > 0)
            {
                Console.WriteLine(". El primer numero ingresado es POSITIVO");
            }
            else
            {
                Console.WriteLine(". El primer numero ingresado es NEGATIVO");
            }
            acumulador += num1;

            string texto2 = Console.ReadLine();
            num2 = sbyte.Parse(texto2);
            contador++;
            if (num2 > 0)
            {
                Console.WriteLine(". El segundo numero ingresado es POSITIVO");
            }
            else
            {
                Console.WriteLine(". El segundo numero ingresado es NEGATIVO");
            }
            acumulador += num2;

            Console.WriteLine(". Se ingreso la siguiente cantidad de numeros: {0}", contador);
            Console.WriteLine(". El valor del acumulador es de: {0}", acumulador);

            if (num1 < num2)
                menor = num1;
            else
                menor = num2;

            Console.WriteLine($". El numenor numero ingresado ha sido el numero: {menor}");
        }
        private static void SalirDelPrograma()
        {
            char desicion;

            Console.WriteLine();
            do
            {
                Console.WriteLine("Desea salir del programa? y/n");
                desicion = char.Parse(Console.ReadLine());

            } while (desicion != 'n' && desicion != 'y');
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            while (desicion == 'n')
            {
                CargayCalculo();
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Desea salir del programa? y/n");
                    desicion = char.Parse(Console.ReadLine());

                } while (desicion != 'n' && desicion != 'y');
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
            }
        }
        private static void Mostrar()
        {
            Bienvenida();
            CargayCalculo();
            SalirDelPrograma();
        }
        public static void DondeSucedeLaMagia()
        {
            Mostrar();
        }
    }
}
