using System;
using System.Drawing;
using System.Text;
using Ej._11_Validacion;

namespace ConsolaEj11
{
    internal class Program
    {
        // Declaro Atributos estaticos
        private static int maximo;
        private static int minimo;
        static void Main(string[] args)
        {
            int valor;
            int acumNumeros = 0;
            int contNumeros = 0;
            int rangoMaximo = 100;
            int rangominimo = -100;

            // Inicializo
            maximo = int.MinValue;
            minimo = int.MaxValue;

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

            

            DateTime datetime = new DateTime(2021, 08, 23);

            

            
            Console.ReadKey();
        }

        public static void EvaluarMaximo(int valor)
        {
            if (valor > maximo)
                maximo = valor;
        }
        public static void Evaluarminimo(int valor)
        {
            if (valor < minimo)
                minimo = valor;
        }

        

    }
}
