using LibreriaParaCicloFor;

namespace ConsolaParaCicloFor
{

    public class Program
    {
        private static float NumeroDeEjercicio()
        {
            float numeroDeEjercio;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ingrese el numero del ejercicio \t");
            Console.Write("Ejercicio N: ");

            string texto = Console.ReadLine();
            Console.Clear();

            numeroDeEjercio = float.Parse(texto);

            return numeroDeEjercio;
        }
        private static void SeleccionDeEjercicio()
        {
            switch (NumeroDeEjercicio())
            {
                // Ejercicios 1
                case 01.1f:
                    Console.WriteLine();
                    Ejercicio01_1.DondeSucedeLaMagia();
                    break;
                case 01.2f:
                    Console.WriteLine();
                    Ejercicio01_2.DondeSucedeLaMagia();
                    break;
                case 01.3f:
                    Console.WriteLine();
                    Ejercicio01_3.DondeSucedeLaMagia();
                    break;
            }
        }
        private static void Menu()
        {
            SeleccionDeEjercicio();
        }

        static void Main()
        {
            Menu();
        }
    }
}