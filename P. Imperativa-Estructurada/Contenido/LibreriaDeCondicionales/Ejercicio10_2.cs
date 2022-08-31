﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Leer 3 números enteros diferentes e imprimir el número mayor de los tres. 
    Indicar la cantidad de números ingresados. 
     */
    #endregion
    public class Ejercicio10_2
    {
        private static void Bievenida()
        {
            Console.WriteLine("Se ingreso al ejercicio {0}", nameof(Ejercicio10_2));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int n1, n2, n3;
            int maximo = 0;
            int contador = 0;

            Console.WriteLine("Ingresar 3 numeros distintos: ");

            string texto1 = Console.ReadLine();
            string texto2 = Console.ReadLine();
            string texto3 = Console.ReadLine();

            n1 = int.Parse(texto1);
            contador += 1; // Asigancion Compuesta
            n2 = int.Parse(texto2);
            contador++; // Inremento
            n3 = int.Parse(texto3);
            contador = contador + 1;

            Console.WriteLine("Se ingresaron {0} numeros al sistemas.", contador);

            if (n1 > n2)
                maximo = n1;
            else
                maximo = n2;
            if (n3 > maximo)
            {
                maximo = n3;
                Console.WriteLine(". El mayor numero de los 3 ingresados es el {0}", maximo);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("El mayor numero de los 3 ingresados es el {0}", maximo);

            }
        }
        private static void Mostrar()
        {
            Bievenida();
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
