using System;

namespace Ejercicio1
{
    #region Enunciado
    /* 
    1. Sumar 2 numeros enteros y mostrar su resultado por consola.
    */
    #endregion

    class Program
    {
        private static int CalcularSuma()
        {
            int num1;
            int num2;
            int resultado;

            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero:");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;
            return resultado;
        }
        private static void MostrarResultado()
        {
            Console.WriteLine("El resultado de esta suma es: " + CalcularSuma());
        }
        private static void DondeLaMagiaSucede()
        {
            MostrarResultado();
        }

        static void Main(string[] args)
        {
            DondeLaMagiaSucede();
        }
    }
}
