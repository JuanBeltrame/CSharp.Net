using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Ingresar un número entero e indicar si el número ingresado es Par o Impar. 
    Indicar la cantidad de números ingresados y 
    finalmente guardar el número ingresado en un acumulador e indicar el valor final del acumulador.
     */
    #endregion
    public sealed class Ejercicio03_3
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio03_3));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int numero;
            int contador = 0;
            int acumulador = 0;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado fue el: {0}", numero);
            Console.WriteLine();

            if (numero % 2 == 0)
            {
                contador += 1;
                acumulador += numero;
                Console.WriteLine("El valor del acumulador es de:"+acumulador);
                Console.WriteLine($"Se ingresaron: {contador} numero");
                Console.WriteLine("El numero ingresado es Par:");
            }
            else
            {
                contador += 1;
                acumulador += numero;
                Console.WriteLine("El valor del acumulador es de: "+acumulador);
                Console.WriteLine($"Se ingresaron: {contador} numero");
                Console.WriteLine("El numero ingresado es Impar:");
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
