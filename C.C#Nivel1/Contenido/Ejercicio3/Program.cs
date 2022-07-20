using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            3.Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
            y la velocidad promedio de un vehículo. 
            Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro 
            teniendo en cuenta los datos ingresados.
            */

            float kilometros, velociad, tiempo;

            Console.WriteLine("Ingrese la distancia: ");
            kilometros = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad Promedio:");
            velociad = float.Parse(Console.ReadLine());

            tiempo = kilometros / velociad;

            Console.WriteLine("El tiempo sera de: " + tiempo.ToString("0.00") + " horas...");



        }
    }
}
