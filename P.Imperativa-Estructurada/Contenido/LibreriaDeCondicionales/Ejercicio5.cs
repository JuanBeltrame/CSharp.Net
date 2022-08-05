using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Hacer un programa para ingresar un numero y que luego se emita un cartel por pantalla que diga: 
    "Positivo" si el numero es mayor a cero.
    "Negativo" si el numero es menor a cero.
    o bien, que diga: "Cero" si el numero es igual a cero.
    */
    #endregion
    public class Ejercicio5
    {
        private static int CargaYCalculo()
        {
            int numero;

            Console.WriteLine("Ingresar un numero: ");

            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"El numero {numero} es Positivo");
                return numero;
            }

            else if (numero < 0)
            {
                Console.WriteLine($"El numero {numero} es Negativo");
                return numero;
            }
            else if (numero == 0)
            {
                Console.WriteLine($"El numero ingresado fue {numero}");
                return numero;
            }
            else
                return -1;
        }
        private static void MostrarResultado()
        {
            Console.WriteLine(CargaYCalculo()); 
        }
        public static void DondeLaMagiaSucede()
        {
            MostrarResultado();
        }
    }
}
