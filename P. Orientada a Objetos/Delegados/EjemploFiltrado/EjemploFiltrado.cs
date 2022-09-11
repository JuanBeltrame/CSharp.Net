using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegados;

namespace Delegados.EjemploFiltrado
{
    public class EjemploFiltrado
    {
        private static List<int> list;

        public static void MostrarNumeros()
        {
            string numeros = "";

            foreach (int numero in list)
            {
                numeros += $"{numero} | ";
            }
            Console.WriteLine($"Numeros antes de filtrar: {numeros}");

        }
        public static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
        public static bool EsNegativo(int numero)
        {
            return numero < 0;
        }
        public static void EjecutarEjemplo()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            list = new List<int>()
            {
                 3, 45, 6, -9, 70, -134, 247, 17
            };

            MostrarNumeros();

            list = list.Filtrar(EsPar);

            MostrarNumeros();

            list = list.Filtrar(EsNegativo);

            MostrarNumeros();
        }
    }
}
