using System;

namespace Aplicacion02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Formulas
    {
        public static string DevolverMensaje()
        {
            return "Soy Namespace Numero2";
        }
    }
}
namespace Aplicacion02
{
    public static class Formulas2
    {
        public static string DevolverMensaje2()
        {
            return "Soy Namespace Numero2";
        }
    }
}