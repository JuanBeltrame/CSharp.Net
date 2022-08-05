using System;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Dados 2 numeros enteros distintos, 
    encontrar e informar cual es el mayor numero de los 2.
    */
    #endregion
    public class Ejercicio1
    {
        private static void EncontrarMayor()
        {
            int num1, num2;

            Console.WriteLine("Ingresar un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine($"Los numeros {num1} y {num2} ingresados no deben de ser iguales.");
            else if (num1 > num2)
                Console.WriteLine("El mayor es numero de los 2 ingresados es:"+num1);
            else
                Console.WriteLine("El mayor numero de los 2 ingresados es {0}",num2);
        }
        private static void MuestraElMayor()
        {
            EncontrarMayor();
        }
        public static void DondeLaMagiaSucede()
        {
            MuestraElMayor();
        }
    }
}
