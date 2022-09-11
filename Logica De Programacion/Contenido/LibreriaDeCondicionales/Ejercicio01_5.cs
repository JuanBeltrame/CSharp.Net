using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Dado un numero entero determinar si es positivo o negativo. Indicar la cantidad de numeros ingresados y 
    finalmente guardar el numero ingresado en un acumulador e indicar el valor final del acumulador. 
    Indicar si el numero que ingreso es par o impar.
    Descontar el 10% al número ingresado y luego sumar el 110% al número ingresado.
    */
    #endregion
    public class Ejercicio01_5
    {
        private static void Bienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Se Ingreso al : {nameof(Ejercicio01_5)}");
            Console.WriteLine();
            
        }

        private static void CargaYCalculo()
        {
            int numero;
            string texto;
            int contador = 0;
            int acumulador = 0;
            bool numeroParImpar;
            float porcentajeDescuento;
            float porcentajeAumento;
            int resto;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ingrese un Numero: ");
            texto = Console.ReadLine();
            numero = int.Parse(texto);

            contador++;
            Console.WriteLine();
            Console.WriteLine(". Se ingresaron la siguiente cantidad de numeros: "+contador);

            acumulador += numero;
            Console.WriteLine(". El valor acumulado es de: {0}", numero);

            resto = numero % 2;
            numeroParImpar = (resto == 0) ? true : false;
            Console.WriteLine(". El numero es Par? "+numeroParImpar);

            porcentajeDescuento = numero * (float)0.90f;
            porcentajeAumento = numero * (float)1.10f;
            Console.WriteLine(". El porcentaje del 10% menos del numero da {0: n2}:", porcentajeDescuento);
            Console.WriteLine(". El porcentaje del 110% mas del numero da: {0: n2}", porcentajeAumento);
            


            if(numero > 0)
            {
                Console.WriteLine(". El numero ingresado es Positivo");
            }
            else
            {
                Console.WriteLine(".  numero ingresado es negativo");
            }
        }

        private static void Mostrar()
        {
            Bienvenida();
            CargaYCalculo();
        }

        public static void DondeLaMagiaSucede()
        {
            Mostrar();
            
        }


    }
}
