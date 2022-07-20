 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngresoDatos();
            Console.ReadKey();        }

        // Metodo Ejemplo1 
        static void IngresoDatos()
        {
            string Nombre;
            Console.WriteLine("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + Nombre); 
        }
    }
}
