using System;

namespace Ejercicio19_Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");
            Console.WriteLine($"Cantidad sumas: {(int)sumador}"); 

            string resultadoString = sumador.Sumar("Hola"," Mundo");
            Console.WriteLine($"Resultado string: {resultadoString}");
            Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");
            Console.WriteLine($"Cantidad sumas: {(int)sumador}");

            long resultadoLong = sumador.Sumar(15L, 20L);
            Console.WriteLine($"Resultado Long: {resultadoLong}");
            Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");
            Console.WriteLine($"Cantidad sumas: {(int)sumador}");

            Sumador sumador2 =  new Sumador(1);

            long resultadoLong2 = sumador2.Sumar(15L, 20L);
            Console.WriteLine($"Resultado Long: {resultadoLong2}");
            Console.WriteLine($"Cantidad sumas: {(int)sumador2}");

            Console.WriteLine($"Suma de Sumadores: {sumador + sumador2}");

            Console.WriteLine($"Tienen la misma cantidad de sumas?: {sumador - sumador2}");
        }
    }
}
