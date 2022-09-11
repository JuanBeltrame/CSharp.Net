using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado 
    /*
    Leer 2 numeros ennteros, si son iguales que los multiplique. 
    Si el primero es mayor que el segundo que los reste 
    y sino que los sume
     */

    #endregion
    public class Ejercicio07_1
    {
        private static void CargaYCalculo()
        {
            int num1, num2;
            int suma, resta, multiplicacion;

            Console.WriteLine("Ingresar 2 numeros: ");
            Console.WriteLine();

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("A continuacion los numeros va a ser multiplicados: ");
                multiplicacion = num1 * num2;
                Console.WriteLine(multiplicacion);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Se realizara una resta con los numeros ingresados: ");
                resta = num1 - num2;
                Console.WriteLine(resta);
            }
            else
            {
                Console.WriteLine("Se realizara una suma con los numeros ingresados: ");
                suma = num1 + num2;
                Console.WriteLine(suma);
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
