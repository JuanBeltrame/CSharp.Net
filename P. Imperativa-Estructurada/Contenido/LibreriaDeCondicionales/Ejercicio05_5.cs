using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Dados 2 números enteros distintos, encontrar e informar cual es el mayor. 
    Indicar la cantidad de números ingresados y 
    finalmente guardar los valores ingresados en un acumulador e indicar el valor final del acumulador.
    Mostrar el promedio final.
    Indicar en que posicion ingreso el numero mas chico. 
     */
    #endregion
    public class Ejercicio05_5
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio05_5));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int num1, num2;
            int contador = 0;
            int acumulador = 0;
            float promedio;
            int mayor = 0;

            Console.WriteLine("Ingrese 2 numeros: ");

            num1 = int.Parse(Console.ReadLine());
            contador++;
            num2 = int.Parse(Console.ReadLine());
            contador++;
            acumulador = num1 + num2;
            promedio = (num1 + num2) / contador;

            if (num1 == num2)
            {
                Console.WriteLine("Se ingresaron: {0} numeros", contador);
                Console.WriteLine("El valor del acumulador es de: " + acumulador);
                Console.WriteLine($"El promedio es {promedio}");
                Console.WriteLine("Los numeros no deben ser iguales");
            }
            else if (num1 > num2)
            {
                mayor = num1;
                Console.WriteLine("El numero mas chico se ingreso segundo");
                Console.WriteLine("Se ingresaron: {0} numeros", contador);
                Console.WriteLine("El valor del acumulador es de: " + acumulador);
                Console.WriteLine($"El promedio es {promedio}");
                Console.WriteLine("El numero mas grande de los dos es el: {0}", mayor);
            }
            else
            {
                mayor = num2;
                Console.WriteLine("El numero mas chico se ingreso primero");
                Console.WriteLine("Se ingresaron: {0} numeros", contador);
                Console.WriteLine("El valor del acumulador es de: " + acumulador);
                Console.WriteLine($"El promedio es {promedio}");
                Console.WriteLine("El numero mas grande de los dos es el {0}", mayor);
            }
        }
        private static void Mostrar()
        {
            Bienvenida();
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
