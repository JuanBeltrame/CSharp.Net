using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Hacer un programa para ingresar un numero entero y que luego se emita un cartel por pantalla que diga:
    "Positivo" si el numero es mayor cero, "Negativo" si el numero es menor a cero o "Cero" si el numero es igual a cero. 
    */
    #endregion
    public class Ejercicio02_1
    {
        private static void CargaYCalculo()
        {
            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Se ingreso el numero: " + numero);
            if (numero > 0)
            {
                Console.WriteLine($"El numero ingresado {numero} es Positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"El numero ingresado {numero} es Negativo");
            }
            else
            {
                Console.WriteLine("El numero ingresado ha sido el numero: {0}", numero);
            }
        }
        public static void DondeLaMagiaSucede()
        {
            CargaYCalculo();
        }

    }
}
