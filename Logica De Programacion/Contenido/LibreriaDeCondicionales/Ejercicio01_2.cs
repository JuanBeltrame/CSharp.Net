using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Dado un numero entero determinar si es positivo o negativo. Indicar la cantidad de numeros ingresados. 
    */
    #endregion

    public class Ejercicio01_2
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio01_2));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int numero1;
            int contador = 0;

            Console.WriteLine("Ingrese un numero entero:");
            numero1 = int.Parse(Console.ReadLine());

            if (numero1 > 0)
            {
                contador += 1;
                Console.WriteLine($"Se ingreso {contador} solo numero");
                Console.WriteLine("Se ingreso el numero: {0}", numero1);
                Console.WriteLine("El numero ingresado es positivo:");
            }
            else
            {
                contador += 1;
                Console.WriteLine($"Se ingreso {contador} solo numero");
                Console.WriteLine("Se ingreso el numero: {0}", numero1);
                Console.WriteLine("El numero que se ingreso es Negativo");
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
