using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double PagoxDia;
            int Dias;

            Console.WriteLine("Ingresa tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Cuanto te pagan por dia trabajado?");
            PagoxDia = double.Parse(Console.ReadLine());

            Console.WriteLine("Cuantos dias trabajaste?");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por tu trabajados es: " + CalcularTotal(PagoxDia, Dias));
            Console.ReadKey();
        }

        // Metodo para obtener el total de dinero ganado por trabajo

        static double CalcularTotal(double Parametro1, int Parametro2)
        {
            double Total;
            Total = (Parametro1 * Parametro2);
            return Total;
        }
    }
}
