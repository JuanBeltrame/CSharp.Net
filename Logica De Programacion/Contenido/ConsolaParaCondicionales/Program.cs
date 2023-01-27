using System;
using LibreriaDeCondicionales;

namespace ConsolaParaCondicionales
{
    internal class Program
    {
        private static float NumeroDeEjercicio()
        {
            float numeroDeEjercicio;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ingrese el Numero del ejercicio: \t");
            Console.Write("Ejercicio N: ");

            string texto = Console.ReadLine();
            Console.Clear();

            numeroDeEjercicio = float.Parse(texto);

            return numeroDeEjercicio;
        }
        private static void SeleccionDeEjercicio()
        {
            switch (NumeroDeEjercicio())
            {
                #region Ejercicios 1

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
                case 01.5f:
                    Console.WriteLine();
                    Ejercicio01_5.DondeLaMagiaSucede();
                    break;

                #endregion

                #region Ejercicios 2

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

                #endregion

                #region Ejercicios 3

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

                #endregion

                #region Ejercicios 4

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

                #endregion

                #region Ejercicios 5

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

                #endregion

                #region Ejercicios 6

                case 06.1f:
                    Console.WriteLine();
                    Ejercicio06_1.DondeLaMagiaSucede();
                    break;
                case 06.2f:
                    Console.WriteLine();
                    Ejercicio06_2.DondeLaMagiaSucede();
                    break;
                case 06.3F:
                    Console.WriteLine();
                    Ejercicio06_3.DondeLaMagiaSucede();
                    break;
                case 06.4f:
                    Console.WriteLine();
                    Ejercicio06_4.DondeLaMagiaSucede();
                    break;
                case 06.5f:
                    Console.WriteLine();
                    Ejercicio06_5.DondeLaMagiaSucede();
                    break;

                #endregion

                #region Ejercicios 7

                case 07.1f:
                    Console.WriteLine();
                    Ejercicio07_1.DondeLaMagiaSucede();
                    break;
                case 07.2f:
                    Console.WriteLine();
                    Ejercicio07_2.DondeLaMagiaSucede();
                    break;
                case 07.3f:
                    Console.WriteLine();
                    Ejercicio07_3.DondeLaMagiaSucede();
                    break;
                case 07.4f:
                    Console.WriteLine();
                    Ejercicio07_4.DondeLaMagiaSucede();
                    break;
                case 07.5f:
                    Console.WriteLine();
                    Ejercicio07_5.DondeLaMagiaSucede();
                    break;
                case 07.6f:
                    Console.WriteLine();
                    Ejercicio07_6.DondeLaMagiaSucede();
                    break;
                case 07.7f:
                    Console.WriteLine();
                    Ejercicio07_7.DondeLaMagiaSucede();
                    break;

                #endregion

                #region Ejercicios 8

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

                #endregion


                // Ejercicios 9
                case 09.1F:
                    Console.WriteLine();
                    Ejercicio09_1.DondeSucedeLaMagia();
                    break;
                case 09.2f:
                    Console.WriteLine();
                    Ejercicio09_2.DondeSucedeLaMagia();
                    break;
                case 09.3f:
                    Console.WriteLine();
                    Ejercicio09_3.DondeSucedeLaMagia();
                    break;
                case 09.4f:
                    Console.WriteLine();
                    Ejercicio09_4.DondeSucedeLaMagia();
                    break;

                // Ejercicios 10
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

                // Ejercicios 11
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
