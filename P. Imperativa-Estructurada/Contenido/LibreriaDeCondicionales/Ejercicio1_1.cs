﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
     Dado un numero entero determinar si es positivo o negativo
    */
    #endregion

    public class Ejercicio1_1
    {
        private static void CargaYCalculo()
        {
            int numero1;

            Console.WriteLine("Ingrese un numero entero:");
            numero1 = int.Parse(Console.ReadLine());

            if (numero1 > 0)
            {
                Console.WriteLine("Se ingreso el numero: {0}", numero1);
                Console.WriteLine("El numero ingresado es positivo:");
            }
            else
            {
                Console.WriteLine("Se ingreso el numero: {0}", numero1);
                Console.WriteLine("El numero que se ingreso es Negativo");
            }
        }
        private static void Mostrar()
        {
            CargaYCalculo();
        }
        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
