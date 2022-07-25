using System;
using Ej._11_Validacion;

namespace ConsolaEj11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            bool esNumero;
            int acumNumeros = 0;
            int contNumeros = 0;
            int valorMaximo = 100;
            int valorminimo = -100;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;

            while (contNumeros <= 10)
            {
                Console.WriteLine("Ingresar un numero:");
                esNumero = int.TryParse(Console.ReadLine(), out valor);

                if (esNumero)
                {
                    if (Validacion.Validar(valor, valorminimo, valorMaximo))
                    {
                        acumNumeros += valor;
                        if (valor > maximo)
                        {
                            maximo = valor;
                        }
                        else if (valor < minimo)
                        {
                            minimo = valor;
                        }
                        contNumeros++;
                        Console.WriteLine("Esta en el rango");
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
            Console.WriteLine(" El numero maximo es: {0}", maximo);
            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El promedio total es: {0}",acumNumeros/contNumeros);
            Console.ReadKey();
        }
    }
}
