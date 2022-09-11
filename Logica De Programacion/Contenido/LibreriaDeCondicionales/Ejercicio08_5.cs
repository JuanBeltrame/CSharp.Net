using System;
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
    Finalmente guardar los valores ingresados en un acumulador e indicar el valor final del acumulador.
    Mostrar el promedio obtenido de los numeros ingresados. 
    Indicar cual es el Mayor numero ingresado. 
    */
    #endregion
    public class Ejercicio08_5
    {

        private static void Bienvenida()
        {
            Console.WriteLine("Se ingreso al: " + nameof(Ejercicio08_5));
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
            byte contador = 0;
            int acumulador = 0;
            float promedio = 0;

            Console.WriteLine("Ingrese dos numeros: ");
            texto1 = Console.ReadLine();
            texto2 = Console.ReadLine();

            n1 = byte.Parse(texto1);
            contador += 1; // Asignacion Compuesta
            n2 = int.Parse(texto2);
            contador++; // Incremento
            Console.WriteLine($"Se ingresaron {contador} nunmeros");

            acumulador += n1;
            acumulador += n2;
            Console.WriteLine("En el acumulador hay {0}", acumulador);

            promedio = (float)acumulador / (float)contador;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);

            if (n1 > n2)
            {
                maximo = n1;
                resultado = maximo - n2;
                Console.WriteLine(resultado);
                Console.WriteLine($"El mayor numero ingresado fue el numnero: {maximo}");
            }
            else
            {
                maximo = n2;
                resultado = maximo - n1;
                Console.WriteLine(resultado);
                Console.WriteLine($"El mayor numero ingresado fue el numnero: {maximo}");
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
