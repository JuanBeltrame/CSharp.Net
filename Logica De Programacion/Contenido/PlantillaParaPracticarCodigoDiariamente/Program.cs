using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PlantillaParaPracticarCodigoDiariamente
{
    internal class Program
    {
        private static int[] arrayDeInt = new int[10];


        public Program()
        {
            
            
        }

        private static void MostrarLongitudDeArray()
        {
            Console.WriteLine(arrayDeInt.Length);
        }

        // Llenar un arreglo de manera automática // Usando for
        private static void ArregloDeManeraAutomatica()
        {
            for (int i = 0; i < 10; i++)
            {
                arrayDeInt[i] = i;
            }
        }
        
        
        // Mostrar un arreglo 
        private static void MostrarUnArregloAutomatico()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayDeInt[i]);
            }
        }

        static void Main()
        {
            MostrarLongitudDeArray();
            ArregloDeManeraAutomatica();
            MostrarUnArregloAutomatico();
        }
    }
}