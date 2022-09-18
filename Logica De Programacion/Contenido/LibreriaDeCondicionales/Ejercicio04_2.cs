using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Hacer un programa para ingresar un numero entero y que luego se emita por pantalla un cartel alcaratorio si:
    "Es mayor a 10" o "No es mayor a 10". Indicar la cantidad de numeros ingresados.
    */
    #endregion
    public sealed class Ejercicio04_2
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio04_2));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int numero, contador;

            contador = 0;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                contador += 1;
                Console.WriteLine("La cantidad de numeros ingresados son: {0}", contador);
                Console.WriteLine("Se ingreso el numero {0} ", numero);
                Console.WriteLine("Dicho numero ingresado es Mayor a 10");
            }
            else
            {
                contador++;
                Console.WriteLine("La cantidad de numeros ingresados son: {0}", contador);
                Console.WriteLine("Se ingreso el numero {0} ", numero);
                Console.WriteLine("El numero ingresado es menor a 10");
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
