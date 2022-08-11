using System;

namespace Ejemplo_Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Torneo torneo = new Torneo(10, 5);

            //float promedioGoles = torneo.PromedioGoles;
            //Console.WriteLine($"El promedio de goles es de: {promedioGoles}");

            //torneo.TotalPartidos = 20;
            //Console.WriteLine($"El promedio de goles es de: {torneo.PromedioGoles}");

            //ConsoleColor color = Console.ForegroundColor;
            //Console.WriteLine($"nombre: {color} - numero {(int) color}");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"nombre: {Console.ForegroundColor} - numero {(int)color}");

            Torneo torneo = new Torneo(10, 5, Deporte.Futbol);
            Console.WriteLine($"El Deporte del torneo es: {torneo.DeporteDelTorneo}");
        }
    }
}
