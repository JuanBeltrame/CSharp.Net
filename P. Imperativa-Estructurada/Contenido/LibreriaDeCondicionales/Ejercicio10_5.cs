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
    Finalmente guardar los valores ingresados en un acumulador e indicar el valor final del acumulador. 
    Mostrar el promedio obtenido de los números ingresados.
    Indicar en qué posición ingresó el número más chico. 
     */
    #endregion
    public class Ejercicio10_5
    {
        private static void Bievenida()
        {
            Console.WriteLine("Se ingreso al ejercicio {0}", nameof(Ejercicio10_5));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int n1, n2, n3;
            int maximo = 0;
            int contador = 0;
            int acumulador = 0;
            float promedio;
            

            Console.WriteLine("Ingresar 3 numeros distintos: ");

            string texto1 = Console.ReadLine();
            string texto2 = Console.ReadLine();
            string texto3 = Console.ReadLine();

            n1 = int.Parse(texto1);
            contador += 1; // Asigancion Compuesta
            acumulador += n1;

            n2 = int.Parse(texto2);
            contador++; // Incremento
            acumulador += n2;

            n3 = int.Parse(texto3);
            contador = contador + 1;
            acumulador = acumulador + n3;

            promedio = (float)acumulador / (float)contador;

            Console.WriteLine();
            Console.WriteLine(". Se ingresaron {0} numeros al sistema.", contador); // Formato Compuesto
            Console.WriteLine();
            Console.WriteLine($". El contenido del {nameof(acumulador)} es de {acumulador}"); // Strings Interpolados
            Console.WriteLine();
            Console.WriteLine(". El " + nameof(promedio) + " obtenido de los numeros ingresados es: " + promedio); // Concatenar
            Console.WriteLine();


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
                Console.WriteLine(". El mayor numero de los 3 ingresados es el {0}", maximo);
                Console.WriteLine();
            }

            if (n1 < n2 && n1 < n3)
            {
                int posicion = 1;
                Console.WriteLine(". El numero mas chico ingreso en posicion {0}", posicion);
            }
            else if (n2 < n1 && n2 < n3)
            {
                int posicion = 2;
                Console.WriteLine(". El numero mas chico ingreso en posicion {0}", posicion);
            }
            else
            {
                int posicion = 3;
                Console.WriteLine(". El numero mas chico ingreso en posicion {0}", posicion);
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
