using System;
using LibreriaDeCondicionales;

namespace ConsolaParaCondicionales
{
    internal class Program
    {
        private static float NumeroDeEjercicio()
        {
            float numeroDeEjercicio;

            Console.WriteLine("Ingrese el Numero del ejercicio: ");
            Console.Write("Ejercicio N: ");
            string texto = Console.ReadLine();

            numeroDeEjercicio = float.Parse(texto);

            return numeroDeEjercicio;
        }
        private static void SeleccionDeEjercicio()
        {
            switch (NumeroDeEjercicio())
            {

                case 01.1f:
                    Console.WriteLine();
                    Ejercicio01_1.DondeLaMagiaSucede();
                    break;
                case 01.2f:
                    Console.WriteLine();
                    Ejercicio01_2.DondeLaMagiaSucede();
                    break;
                case 01.3f:
                    Console.WriteLine();
                    Ejercicio01_3.DondeLaMagiaSucede();
                    break;
                case 01.4f:
                    Console.WriteLine();
                    Ejercicio01_4.DondeLaMagiaSucede();
                    break;


                case 02.1f:
                    Console.WriteLine();
                    Ejercicio02_1.DondeLaMagiaSucede();
                    break;
                case 02.2f:
                    Console.WriteLine();
                    Ejercicio02_2.DondeLaMagiaSucede();
                    break;
                case 02.3f:
                    Console.WriteLine();
                    Ejercicio02_3.DondeLaMagiaSucede();
                    break;


                case 03.1f:
                    Console.WriteLine();
                    Ejercicio03_1.DondeLaMagiaSucede();
                    break;
                case 03.2f:
                    Console.WriteLine();
                    Ejercicio03_2.DondeLaMagiaSucede();
                    break;
                case 03.3f:
                    Console.WriteLine();
                    Ejercicio03_3.DondeLaMagiaSucede();
                    break;


                case 04.1f:
                    Console.WriteLine();
                    Ejercicio04_1.DondeLaMagiaSucede();
                    break;
                case 04.2f:
                    Console.WriteLine();
                    Ejercicio04_2.DondeLaMagiaSucede();
                    break;
                case 04.3f:
                    Console.WriteLine();
                    Ejercicio04_3.DondeLaMagiaSucede();
                    break;


                case 05.1f:
                    Console.WriteLine();
                    Ejercicio05_1.DondeLaMagiaSucede();
                    break;
                case 05.2f:
                    Console.WriteLine();
                    Ejercicio05_2.DondeLaMagiaSucede();
                    break;
                case 05.3f:
                    Console.WriteLine();
                    Ejercicio05_3.DondeLaMagiaSucede();
                    break;
                case 05.4f:
                    Console.WriteLine();
                    Ejercicio05_4.DondeLaMagiaSucede();
                    break;
                case 05.5f:
                    Console.WriteLine();
                    Ejercicio05_5.DondeLaMagiaSucede();
                    break;

                case 06.1f:
                    Console.WriteLine();
                    Ejercicio06_1.DondeLaMagiaSucede();
                    break;
                case 06.2f:
                    Console.WriteLine();
                    Ejercicio06_2.DondeLaMagiaSucede();
                    break;

                case 07.7f:
                    Console.WriteLine();
                    Ejercicio07_7.DondeLaMagiaSucede();
                    break;

                case 08.1f:
                    Console.WriteLine();
                    Ejercicio08_1.DondeSucedeLaMagia();
                    break;
                case 08.2f:
                    Console.WriteLine();
                    Ejercicio08_2.DondeSucedeLaMagia();
                    break;
                case 08.3f:
                    Console.WriteLine();
                    Ejercicio08_3.DondeSucedeLaMagia();
                    break;
                case 08.4f:
                    Console.WriteLine();
                    Ejercicio08_4.DondeSucedeLaMagia();
                    break;
                case 08.5f:
                    Console.WriteLine();
                    Ejercicio08_5.DondeSucedeLaMagia();
                    break;
                case 08.6f:
                    Console.WriteLine();
                    Ejercicio08_6.DondeSucedeLaMagia();
                    break;
                case 08.7f:
                    Console.WriteLine();
                    Ejercicio08_7.DondeSucedeLaMagia();
                    break;
                case 08.8f:
                    Console.WriteLine();
                    Ejercicio08_8.DondeSucedeLaMagia();
                    break;

                case 10.1f:
                    Console.WriteLine();
                    Ejercicio10_1.DondeLaMagiaSucede();
                    break;
                case 10.2f:
                    Console.WriteLine();
                    Ejercicio10_2.DondeLaMagiaSucede();
                    break;
                case 10.3f:
                    Console.WriteLine();
                    Ejercicio10_3.DondeLaMagiaSucede();
                    break;
                case 10.4f:
                    Console.WriteLine();
                    Ejercicio10_4.DondeLaMagiaSucede();
                    break;
                case 10.5f:
                    Console.WriteLine();
                    Ejercicio10_5.DondeLaMagiaSucede();
                    break;
                case 10.6f:
                    Console.WriteLine();
                    Ejercicio10_6.DondeLaMagiaSucede();
                    break;
                case 10.7f:
                    Console.WriteLine();
                    Ejercicio10_7.DondeLaMagiaSucede();
                    break;
                default:
                case 11.1f:
                    Console.WriteLine();
                    Ejercicio11_1.DondeLaMagiaSucede();
                    break;

            }
        }
        private static void Menu()
        {
            SeleccionDeEjercicio();
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
