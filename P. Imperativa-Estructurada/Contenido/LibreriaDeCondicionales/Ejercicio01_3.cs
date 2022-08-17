using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Dado un numero entero determinar si es positivo o negativo. Indicar la cantidad de numeros ingresados y 
    finalmente guardar el numero ingresado en un acumulador e indicar el valor final del acumulador. 
    */
    #endregion

    public class Ejercicio01_3
    {
        private static void CargaYCalculo()
        {
            int numero1;
            int contador = 0;
            int acumulador = 0;

            Console.WriteLine("Ingrese un numero entero:");
            numero1 = int.Parse(Console.ReadLine());

            if (numero1 > 0)
            {
                contador += 1;
                acumulador += numero1;
                Console.WriteLine($"Se ingreso {contador} solo numero");
                Console.WriteLine($"El valor del acumulador es: {acumulador}");
                Console.WriteLine("Se ingreso el numero: {0}", numero1);
                Console.WriteLine("El numero ingresado es positivo:");
            }
            else
            {
                contador += 1;
                acumulador += numero1;
                Console.WriteLine($"Se ingreso {contador} solo numero");
                Console.WriteLine($"El valor del acumulador es: {acumulador}");
                Console.WriteLine("Se ingreso el numero: {0}", numero1);
                Console.WriteLine("El numero que se ingreso es Negativo");
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
