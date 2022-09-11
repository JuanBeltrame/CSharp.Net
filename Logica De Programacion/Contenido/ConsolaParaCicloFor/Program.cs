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
            Console.WriteLine("Ejercicio N: ");

            string texto = Console.ReadLine();
            numeroDeEjercio = float.Parse(texto);

            Console.Clear();

            return numeroDeEjercio;
        }
        static void Main()
        {
            //Ejercicio01_1.CargaYCalculo();

            Ejercicio02_1.DondeLaMagiaSucede(); 
        }
    }
}