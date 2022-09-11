using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Ingresar 3 numeros enteros distintos. Determinar e informar si ingresaron en orden creciente. 
    */
    #endregion
    public class Ejercicio8
    {
        private static void CargaYCalculo()
        {
            int n1, n2, n3;

            Console.WriteLine("Ingrese tres numeros distintos: ");
            n1 = int.Parse(Console.ReadLine());

            n2 = int.Parse(Console.ReadLine());
            if (n1 == n2)
                Console.WriteLine("Los numeros deben ser distintos");
            else if (n1 > n2)
            {
                n3 = int.Parse(Console.ReadLine());
                if (n3 == n2 || n3 == n1)
                    Console.WriteLine("Los numeros ingresados deben ser distintos");
                else
                    Console.WriteLine("Los numeros {0},{1},{2}, no fueron ingresados de forma creciente",n1,n2,n3); 
            }
            else
            {
                n3 = int.Parse(Console.ReadLine());
                if (n3 == n2 || n3 == n1)
                    Console.WriteLine("Los numeros ingresados deben ser distintos");
                else if (n2 < n3)
                    Console.WriteLine("Los numeros {0},{1},{2}, si fueron ingresados de forma creciente", n1, n2, n3);
                else
                    Console.WriteLine("Los numeros {0},{1},{2}, no fueron ingresados de forma creciente", n1, n2, n3);
            }
        }
        private static void Mostrar()
        {
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
