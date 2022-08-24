using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    public class Ejercicio01_4
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio01_4));
            Console.WriteLine();
        }
        private static void MostrarMensaje()
        {
            Console.WriteLine("Ingrese un Numero:");
        }
        private static int Carga()
        {
            int numero;

            numero = 5;
            
            return numero; 
        }

        public static void PositivoNegativo()
        {
            if (Carga() > 0)
            {
                Console.WriteLine("Se ingreso el numero: {0}", Carga());
                Console.WriteLine("El numero ingresado es positivo:");
            }
            else
            {
                Console.WriteLine("Se ingreso el numero: {0}", Carga());
                Console.WriteLine("El numero que se ingreso es Negativo");
            }
        } 

        public static void DondeSucedeLaMagia()
        {
            Bienvenida();
            MostrarMensaje();
            PositivoNegativo();
        }
    }
}
