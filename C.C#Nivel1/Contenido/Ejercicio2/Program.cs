using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 

            2. Hacer un programa para solicitar por teclado un número 
            y luego devolver su valor elevado al cubo.

            */

            int n, cubo;

            Console.WriteLine("Ingresar un Numero: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado es: " + n);

            cubo = n * n * n;
            Console.WriteLine("El resultado de elevar " + n + " al cubo es: " + cubo);
        }
    }
}
