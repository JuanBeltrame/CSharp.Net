using System;

namespace Ejercicio2
{
    #region Enunciado
    /* 
    2. Hacer un programa para solicitar por teclado un número 
    y luego devolver su valor elevado al cubo.
    */
    #endregion

    class Program
    {
        private static int CalcularUnCubo()
        {
            int n, cubo;

            Console.WriteLine("Ingresar un Numero: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"El numero ingresado es: {n}");

            cubo = n * n * n;
            return cubo;
        }
        private static void MostrarResultado()
        {
            Console.WriteLine($"El resultado de elevar el numero seleccionado al cubo es: {CalcularUnCubo()}");
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
