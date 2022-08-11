using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado
    /*
    Hacer un programa para ingresar un numero entero y que luego se emita por pantalla un cartel alcaratorio si:
    "Es mayor a 10" o "No es mayor a 10". Indicar la cantidad de numeros ingresados y finalmente
    guardar el numero ingresado en un acumulador e indicar el valor final del acumulador. 
    */
    #endregion
    public class Ejercicio4_3
    {
        private static void CargaYCalculo()
        {
            int numero, contador, acumulador;

            contador = 0;
            acumulador = 0;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                contador += 1;
                acumulador += numero;
                Console.WriteLine("La cantidad de numeros ingresados son: {0}", contador);
                Console.WriteLine("Se ingreso el numero: "+ numero);
                Console.WriteLine("Dicho numero ingresado es Mayor a 10");
                Console.WriteLine($"El valor acumulado es: {acumulador}");
            }
            else
            {
                contador++;
                acumulador += numero;
                
                Console.WriteLine("La cantidad de numeros ingresados son: {0}", contador);
                Console.WriteLine("Se ingreso el numero: "+numero);
                Console.WriteLine("El numero ingresado es menor a 10");
                Console.WriteLine($"El valor acumulado es: {acumulador}");
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
