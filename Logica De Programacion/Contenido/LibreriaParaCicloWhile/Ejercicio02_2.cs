using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParaCicloWhile
{
    #region Enunciado 
    // Hacer un programa que solicite la edad de un grupo de personas.
    // El programa deberá pedir edades hasta que se ingrese una edad menor a 18 años.
    // Deberá mostrar por pantalla cuántas personas mayores se registraron.
    #endregion

    public sealed class Ejercicio02_2
    {
        public static void CargaYCalculo()
        {
            int edad = 0;
            string texto1 = string.Empty;
            int contadorPersonas = 0; 


            Console.WriteLine("Ingrese edad: ");
            texto1 = Console.ReadLine();
            edad = int.Parse(texto1);

            while (edad > 18)
            {
                contadorPersonas++;

                Console.WriteLine("Ingrese edad: ");
                texto1 = Console.ReadLine();
                edad = int.Parse(texto1);
            }

            Console.WriteLine("La cantidad de personas ingresadas mayores de 18 anios han sido: {0}", contadorPersonas);

        }
    }
}
