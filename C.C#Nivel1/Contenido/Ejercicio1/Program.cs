using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;

            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero:");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;
            Console.WriteLine("El resultado de esta suma es: " + resultado);

        }
    }
}
