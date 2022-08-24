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
    */
    #endregion
    public class Ejercicio08_3
    {

        private static void Bienvenida()
        {
            Console.WriteLine("Se ingreso al: " + nameof(Ejercicio08_3));
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

            Console.WriteLine("Ingrese dos numeros: ");
            texto1 = Console.ReadLine();
            texto2 = Console.ReadLine();

            n1 = byte.Parse(texto1);
            contador += 1; // Asignacion Compuesta
            n2 = int.Parse(texto2);
            contador++; // Incremento

            acumulador +=n1;
            acumulador += n2;


            Console.WriteLine($"Se ingresaron {contador} nunmeros");
            Console.WriteLine("En el acumulador hay {0}",acumulador);

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
