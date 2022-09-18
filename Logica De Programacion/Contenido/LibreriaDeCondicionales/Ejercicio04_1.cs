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
    "Es mayor a 10" o "No es mayor a 10";
    */
    #endregion
    public sealed class Ejercicio04_1
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio04_1));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if( numero > 10)
            {
                Console.WriteLine("Se ingreso el numero {0} ",numero);
                Console.WriteLine("Dicho numero ingresado es Mayor a 10");
            }
            else
            {
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
