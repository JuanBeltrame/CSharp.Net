using System;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Dados 2 valores enteros numericos distintos, 
    encontrar e informar cual es el mayor numero de los 2.
    */
    #endregion
    public class ClaseEjercicio1
    {
        public static int EncontrarMayor()
        {
            int num1, num2;

            Console.WriteLine("Ingresar un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        public static void MuestraElMayor()
        {
            Console.WriteLine($"El mayor de los 2 es: {EncontrarMayor()}");
        }
        public static void DondeLaMagiaSucede()
        {
            MuestraElMayor();
        }
    }
}
