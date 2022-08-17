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
    y sino que los sume. Indicar la cantidad de numeros ingresados
    Finalmente guardar los valores ingresados en un acumulador e indicar el valor final del acumulador.
     */

    #endregion
    public class Ejercicio07_3
    {
        private static void CargaYCalculo()
        {
            int num1, num2;
            int suma, resta, multiplicacion;
            int contador = 0;
            int acumulador = 0;

            Console.WriteLine("Ingresar 2 numeros: ");
            Console.WriteLine();

            num1 = int.Parse(Console.ReadLine());
            contador += 1;

            num2 = int.Parse(Console.ReadLine());
            contador += 1;
            Console.WriteLine($"Se ingresaron {contador} numeros");

            acumulador = acumulador + num1;
            acumulador = acumulador + num2;
            Console.WriteLine("El valor acumulado de los 2 numeros ingresados es de:"+acumulador);

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
