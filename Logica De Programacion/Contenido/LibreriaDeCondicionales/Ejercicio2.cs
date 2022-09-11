using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Dados dos numeros enteros distintos, mostrarlos ordenaods en forma creciente.  
    */
    #endregion
    public class Ejercicio2
    {
        private static void MostrarOrdenado()
        {
            int num1, num2;

            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero distinto del anterior: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Los numeros ingresados no deber de ser iguales");
            else if (num1 < num2)
                Console.WriteLine($"Mostrados de manera creciente: {num1}, {num2}");
            else
                Console.WriteLine($"Mostrados de manera creciente: {num2}, {num1}");
        }
        public static void DondeLaMagiaSucede()
        {
            MostrarOrdenado();
        }
    }
}
