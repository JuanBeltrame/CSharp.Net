using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class EjemploFuncion1
    {
        public static void MiFuncion1()
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro...");
            n2 = int.Parse(Console.ReadLine());

            // Logica
            //  = n1 + n2;
            resultado = Sumar1(n1, n2);
            // Fin Logica

            Console.WriteLine("El resultado es" + resultado);
            Console.WriteLine("El contenido de la variable n1 es: "+ n1);

        }
        public static void MiFuncion2()
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro...");
            n2 = int.Parse(Console.ReadLine());

            // Logica
            //  = n1 + n2;
            resultado = Sumar2(ref n1, n2);
            // Fin Logica

            Console.WriteLine("El resultado es" + resultado);
            Console.WriteLine("El contenido de la variable n1 es: " + n1);

        }

        static int Sumar1(int a, int b)
        {
            int r;
            r = a + b;
            return r;
        }

        static int Sumar2(ref int a, int b)
        {
            int r;
            r = a + b;
            a = 9999;
            return r;
        }



    }
}
