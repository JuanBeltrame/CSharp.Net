using System;
using System.Drawing;
using Ej._11_Validacion;

namespace ConsolaEj11
{
    internal class Program
    {
        private static int maximo;
        private static int minimo;
        static void Main(string[] args)
        {
            int valor;
            int acumNumeros = 0;
            int contNumeros = 0;
            int rangoMaximo = 100;
            int rangominimo = -100;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;

            while (contNumeros < 10)
            {
                Console.WriteLine("Ingresar un numero:");

                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    if (Validacion.Validar(valor, rangominimo, rangoMaximo))
                    {
                        acumNumeros += valor;
                        EvaluarMaximo(valor);
                        Evaluarminimo(valor);
                        contNumeros++;
                    }
                    else
                    {
                        Console.WriteLine("No esta en el rango");
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }

            }
            Console.WriteLine($"El numero maximo es: {maximo} y el minimo es: {minimo}");
            Console.WriteLine($"El promedio total es: {acumNumeros / contNumeros}");
            Console.ReadKey();
        }

        public static void EvaluarMaximo(int valor)
        {
            if (valor > maximo)
            {
                maximo = valor;
            }
        }

        public static void Evaluarminimo(int valor)
        {
            if (valor < minimo)
            {
                minimo = valor;
            }
        }
    }
}
