﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Ingresar un numero entero e indicar si el numero ingresado es Par o Impar.
     */
    #endregion
    public sealed class Ejercicio03_1
    {
        private static void Bienvenida()
        {
            Console.WriteLine("Se Ingreso al: " + nameof(Ejercicio03_1));
            Console.WriteLine();
        }
        private static void CargaYCalculo()
        {
            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado fue el: {0}", numero);

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es Par:");
            }
            else
            {
                Console.WriteLine("El numero ingresado es Impar:");
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
