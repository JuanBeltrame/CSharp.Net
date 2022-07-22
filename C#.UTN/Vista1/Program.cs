﻿using System;
using Biblioteca1;

namespace Vista1
{
    internal class Program
    {
        private static float temperaturaCelsius;
        private static float temperaturaKelvin;

        static void Main(string[] args)
        {
            //float temperaturaCelsius = 30;
            //float temperaturaKelvin = ConversorDeTemperatura.ConvertirCelciusAKelvin(temperaturaCelsius);

            temperaturaCelsius = 30;
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelciusAKelvin(temperaturaCelsius);
            MostrarTemperaturas();
            

        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine("Temperatura Celsius: {0}", temperaturaCelsius);
            Console.WriteLine("Temperatura Kelvin: {0}", temperaturaKelvin);
        }
    }
}
