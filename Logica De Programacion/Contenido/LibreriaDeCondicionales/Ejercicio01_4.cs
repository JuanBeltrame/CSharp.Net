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
    Indicar si el numero que ingreso es par o impar.
    */
    #endregion

    public sealed class Ejercicio01_4
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio01_4));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            string texto;
            int numero;
            int contador = 0;
            int acumulador = 0;
            int resto;
            bool parImpar;

            Console.WriteLine("Ingrese un numero entero:");

            texto = Console.ReadLine();
            numero = int.Parse(texto);
            Console.WriteLine(". Se ingreso el numero: {0}", numero);

            contador += 1;
            Console.WriteLine($". Se ingreso {contador} solo numero");

            acumulador += numero;
            Console.WriteLine($". El valor del acumulador es: {acumulador}");

            resto = numero % 2;
            parImpar = (resto == 0) ? true : false;
            Console.WriteLine(". El numero ingresado es par?" + parImpar);


            if (numero > 0)
                Console.WriteLine(". El numero ingresado es positivo:");

            else
                Console.WriteLine(". El numero que se ingreso es Negativo");
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
