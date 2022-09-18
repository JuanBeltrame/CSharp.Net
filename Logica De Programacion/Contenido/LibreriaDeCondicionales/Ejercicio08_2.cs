﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Ingresar 2 numeros distintos y luego emitir por pantalla el resultado de restar: 
    el mayor de ellos con el menor. Indicar al cantidad de numeros ingresados. 
    */
    #endregion
    public sealed class Ejercicio08_2
    {

        private static void Bienvenida()
        {
            Console.WriteLine("Se ingreso al: " + nameof(Ejercicio08_2));
            Console.WriteLine();
        }

        private static void CargaYCalculo()
        {
            int n1;
            int n2;
            int resultado;
            int maximo = 0;
            string texto1;
            string texto2;
            int contador = 0;

            Console.WriteLine("Ingrese dos numeros: ");
            texto1 = Console.ReadLine();
            texto2 = Console.ReadLine();

            n1 = int.Parse(texto1);
            contador += 1; // Asignacion Compuesta
            n2 = int.Parse(texto2);
            contador++; // Incremento

            Console.WriteLine($"Se ingresaron {contador} nunmeros");

            if (n1 > n2)
            {
                maximo = n1;
                resultado = maximo - n2;
                Console.WriteLine(resultado);
            }
            else
            {
                maximo = n2;
                resultado = maximo - n1;
                Console.WriteLine(resultado);
            }
        }
        private static void Mostrar()
        {
            CargaYCalculo();
        }
        public static void DondeSucedeLaMagia()
        {
            Bienvenida();
            Mostrar();
        }
    }
}
