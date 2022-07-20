using System;

namespace Ejercicio19_Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");

            string resultadoString = sumador.Sumar("Hola"," Mundo");
            Console.WriteLine($"Resultado string: {resultadoString}");
            Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");

            long resultadoLong = sumador.Sumar(15L, 20L);
            Console.WriteLine($"Resultado string: {resultadoLong}");
            Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");
        }
    }
}
