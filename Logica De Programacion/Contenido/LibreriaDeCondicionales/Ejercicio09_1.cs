using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado 
    // 9.1 Hacer un programa para ingresar dos números distintos enteros y luego se muestre por pantalla el menor de ellos.
    #endregion
    public sealed class Ejercicio09_1
    {
        // Metodos | 
        private static void Bienvenida()
        {
            Console.WriteLine("Se ingreso al ejercicio {0}", nameof(Ejercicio09_1));
            Console.WriteLine();
        }
        private static void CargayCalculo()
        {
            byte num1 = 0;
            byte num2 = 0;
            byte menor = 0;

            Console.WriteLine("Ingrese 2 numeros distintos");

            string texto1 = Console.ReadLine();
            num1 = byte.Parse(texto1);

            string texto2 = Console.ReadLine();
            num2 = byte.Parse(texto2);

            if (num1 < num2)
                menor = num1;
            else 
                menor = num2;

            Console.WriteLine($"El numenor numero ingresado ha sido el numero: {menor}");
        }
        private static void Mostrar()
        {
            Bienvenida();
            CargayCalculo();
        }
        public static void DondeSucedeLaMagia()
        {
            Mostrar();
        }
    }
}
