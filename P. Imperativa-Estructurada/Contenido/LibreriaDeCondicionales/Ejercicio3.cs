using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Hacer un programa para ingresar un numero entero y que luego se emita por pantalla un cartel aclaratorio si: 
    "Es mayor a 10" o "No es mayor a 10"
     */
    #endregion
    public class Ejercicio3
    {
        private static void CargaYCalculo()
        {
            int num; 

            Console.WriteLine("Ingresar un Numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 10)
                Console.WriteLine($"El numero ingresado {num}, es claramente mayor a 10");
            else if (num < 10)
                Console.WriteLine($" El numero ingresado {num}, es claramente, menor a 10");
            else if (num == 10)
                Console.WriteLine($"El numero ingresado ha sido {num}");
            else
                Console.WriteLine();
        }
        public static void DondeLaMagiaSucede()
        {
            CargaYCalculo();
        }
    }
}
