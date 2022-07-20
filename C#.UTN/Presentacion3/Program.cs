using System;

namespace Presentacion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sobrecargadora.Sumar(5, 8);
            int resultado2 = Sobrecargadora.Sumar(5, 8, 10);
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);

            Console.WriteLine(Sobrecargadora.Concatenar("HOLA","MUNDO"));
            Console.WriteLine(Sobrecargadora.Concatenar("HOLA","MUNDO",12));
        }
    }
}
