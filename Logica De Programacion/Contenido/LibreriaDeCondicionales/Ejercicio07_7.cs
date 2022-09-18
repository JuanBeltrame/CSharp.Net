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
    Mostrar el promedio obtenido de los numeros ingresados. 
    Indicar cual es el Mayor numero ingresado.
    Indicar en que posicion ingreso el numero mas grande.
    Indicar si cada número ingresado es par o impar.
     */

    #endregion
    public sealed class Ejercicio07_7
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se ingreso al: " + nameof(Ejercicio07_7));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int num1, num2;
            int suma, resta, multiplicacion;
            int contador = 0;
            int acumulador = 0;
            float promedio;
            int maximo;
            int posicion;

            Console.WriteLine("Ingresar 2 numeros: ");
            Console.WriteLine();

            num1 = int.Parse(Console.ReadLine());
            bool parImparNum1 = (num1 % 2 == 0) ? true : false;
            Console.WriteLine("El numero ingresado es par?"+parImparNum1);
            contador += 1;


            num2 = int.Parse(Console.ReadLine());
            bool parImparNum2 = (num2 % 2 == 0) ? true : false;
            Console.WriteLine("El numero ingresado es par?"+parImparNum2);

            contador += 1;
            Console.WriteLine($"Se ingresaron {contador} numeros");

            acumulador = acumulador + num1;
            acumulador = acumulador + num2;
            Console.WriteLine("El valor acumulado de los 2 numeros ingresados es de:" + acumulador);

            promedio = (float)acumulador / (float)contador;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);

            if (num1 == num2)
            {
                Console.WriteLine("A continuacion los numeros va a ser multiplicados: ");
                multiplicacion = num1 * num2;
                Console.WriteLine(multiplicacion);
            }
            else if (num1 > num2)
            {
                maximo = num1;
                posicion = 1;
                Console.WriteLine("Se realizara una resta con los numeros ingresados: ");
                resta = num1 - num2;
                Console.WriteLine(resta);
                Console.WriteLine("El mayor numero ingesado es: {0}", maximo);
                Console.WriteLine("El numero mas grande ingreso en la posicion: {0}", posicion);
            }
            else
            {
                maximo = num2;
                posicion = 2;
                Console.WriteLine("Se realizara una suma con los numeros ingresados: ");
                suma = num1 + num2;
                Console.WriteLine(suma);
                Console.WriteLine("El mayor numero ingesado es: {0}", maximo);
                Console.WriteLine("El numero mas grande ingreso en la posicion: {0}", posicion);
            }
        }

        private static void Mostrar()
        {
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            Bienvenida();
            Mostrar();
        }
    }
}
