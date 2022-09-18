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
    Descontar el 10% y sumar el 110% al valor del acumulador. 
    Indicar si cada número ingresado es par o impar.

    */
    #endregion
    public sealed class Ejercicio08_8
    {

        private static void Bienvenida()
        {
            Console.WriteLine("Se ingreso al: " + nameof(Ejercicio08_8));
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
            double promedio = 0;
            byte posicion;
            double porcentaje1;
            double porcentaje2;

            Console.WriteLine("Ingrese dos numeros: ");
            
            texto1 = Console.ReadLine();
            n1 = byte.Parse(texto1);
            bool parImpar1 = (n1 % 2 == 0) ? true : false;
            Console.WriteLine("El numero ingresado ha sido par? " + parImpar1);
            contador += 1; // Asignacion Compuesta
            Console.WriteLine();


            texto2 = Console.ReadLine();
            n2 = int.Parse(texto2);
            bool parImpar2 = (n2 % 2 == 0) ? true : false;
            contador++; // Incremento
            Console.WriteLine("El numero ingresado ha sido par? " + parImpar2); 
            Console.WriteLine();
            Console.WriteLine($"Se ingresaron {contador} nunmeros");

            acumulador += n1;
            acumulador += n2;
            Console.WriteLine("En el acumulador hay {0}", acumulador);

            porcentaje1 = acumulador * 0.90;
            porcentaje2 = acumulador * 1.10;
            Console.WriteLine("El 10% menos, del acumulador es: " + porcentaje1);
            Console.WriteLine("El 110% mas, del valor del acumulador es: " + porcentaje2);

            promedio = (float)acumulador / (float)contador;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);




            if (n1 > n2)
            {
                maximo = n1;
                posicion = 1;
                resultado = maximo - n2;
                
                Console.WriteLine(resultado);
                Console.WriteLine($"El mayor numero ingresado fue el numnero: {maximo}");
                Console.WriteLine("El numero mas grande ingreso en la {0} numero: {1}", nameof(posicion), posicion);
                
                
                
            }
            else
            {
                maximo = n2;
                posicion = 2;
                resultado = maximo - n1;
                Console.WriteLine(resultado);
                Console.WriteLine($"El mayor numero ingresado fue el numnero: {maximo}");
                Console.WriteLine("El numero mas grande ingreso en la {0} numero: {1}", nameof(posicion), posicion);
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
