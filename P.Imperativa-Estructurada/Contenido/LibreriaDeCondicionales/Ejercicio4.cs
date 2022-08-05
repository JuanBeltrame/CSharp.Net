using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Dado un numero entero, determinar si es positivo o negativo. 
     */
    #endregion
    public class Ejercicio4
    {
        private static void CargaYCalculo()
        {
            int numero;

            Console.WriteLine("Ingresar un numero: ");

            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
                Console.WriteLine($"El numero {numero} es Positivo");
            else
                Console.WriteLine($"El numero {numero} es Negativo");
        }
        private static void MostrarResultado()
        {
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            MostrarResultado();
        }
    }
}
