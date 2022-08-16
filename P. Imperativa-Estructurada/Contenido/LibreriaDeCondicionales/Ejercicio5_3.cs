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
     */
    #endregion
    public class Ejercicio5_3
    {
        private static void CargaYCalculo()
        {
            int num1, num2;
            int contador = 0;
            int acumulador; 

            Console.WriteLine("Ingrese 2 numeros: ");

            num1 = int.Parse(Console.ReadLine());
            contador++;
            num2 = int.Parse(Console.ReadLine());
            contador++;
            acumulador = num1 + num2;

            if (num1 == num2)
            {
                Console.WriteLine("Se ingresaron: {0} numeros", contador);
                Console.WriteLine("El valor del acumulador es de: "+acumulador);
                Console.WriteLine("Los numeros no deben ser iguales");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Se ingresaron: {0} numeros", contador);
                Console.WriteLine("El valor del acumulador es de: " + acumulador);
                Console.WriteLine("El numero mas grande de los dos es el: {0}", num1);
            }
            else
            {
                Console.WriteLine("Se ingresaron: {0} numeros", contador);
                Console.WriteLine("El valor del acumulador es de: " + acumulador);
                Console.WriteLine("El numero mas grande de los dos es el {0}", num2);
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
