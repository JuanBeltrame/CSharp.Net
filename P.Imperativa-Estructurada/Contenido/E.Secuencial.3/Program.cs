using System;

namespace Ejercicio3
{
    #region Enunciado
    /* 
    3.Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
    y la velocidad promedio de un vehículo. 
    Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro 
    teniendo en cuenta los datos ingresados.
    */
    #endregion

    internal class Program
    {
        private static float CalculoVelocidadYDistancia()
        {
            float Kilometros, velocidad, tiempo;
            Console.WriteLine("Ingrese la distancia: ");
            Kilometros = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrse la velocidad Promedio:");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = Kilometros / velocidad;
            return tiempo;
        }
        private static void MostrarResultado()
        {
            Console.WriteLine($"El tiempo sera de: {CalculoVelocidadYDistancia().ToString("0.00")} horas");
        }
        private static void DondeSucedeLaMagia()
        {
            MostrarResultado();
        }

        static void Main(string[] args)
        {
            DondeSucedeLaMagia();
        }
    }
}
