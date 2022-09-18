using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    #region Enunciado 
    /*
     Haer un programa para ingresar 2 numeros enteros y que luego emita por pantalla el mayor de ellos
    o un cartel aclaratorio "Son Iguales" en el caso de que asi sea. 
    Indicar la cantidad de numeros ingresados y finalmente guardar los valores ingresados en un acumulador
    e indicar el valor final del acumulador.
    Mostrar el promedio obtenido de los numeros ingresados.
    Indicar en que posicion ingreso el numero mas chico.
     */
    #endregion
    public sealed class Ejercicio06_5
    {
        private static void CargaYCalculo()
        {
            int num1;
            int num2;
            int contador = 0;
            int acumulador = 0;
            float promedio = 0;
            int posicion1 = 1;
            int posicion2 = 2;
            int maximo = 0;

            Console.WriteLine("Ingresar 2 numeros: ");
            Console.WriteLine();

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            contador++;
            contador += 1;
            acumulador = num1 + num2;
            promedio = (float)acumulador / (float)contador;

            if (num1 == num2)
            {
                Console.WriteLine();
                Console.WriteLine($"Los numeros {num1} y {num2} ingresados son iguales");
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El valor acumulado en el acumulador es: " + acumulador);
                Console.WriteLine("El promedio de los numeros ingresados es de: {0}", promedio);
            }
            else if (num1 > num2)
            {
                maximo = num1;
                Console.WriteLine();
                Console.WriteLine("El numero mas chicho ingreso en la posicion: {0}",posicion2);
                Console.WriteLine("El numero {0} es el mayor de los 2", maximo);
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El valor acumulado en el acumulador es: " + acumulador);
                Console.WriteLine("El promedio de los numeros ingresados es de: {0}", promedio);
            }
            else
            {
                maximo = num2;
                Console.WriteLine();
                Console.WriteLine("El numero mas chicho ingreso en la posicion: {0}", posicion1);
                Console.WriteLine("El numero {0} es el mayor de los 2", maximo);
                Console.WriteLine("Se ingreso la siguientes cantidad de numeros: {0}", contador);
                Console.WriteLine("El valor acumulado en el acumulador es: " + acumulador);
                Console.WriteLine("El promedio de los numeros ingresados es de: {0}", promedio);
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
