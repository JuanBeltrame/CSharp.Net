using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operacionMatematica;
            int nOperacion;
            Console.Write("Quieres realizar la tabla de sumar o multiplicar?: ");
            operacionMatematica = Console.ReadLine();
            Console.Write("Que numero de tabla desea que se muestre: ");
            nOperacion = int.Parse(Console.ReadLine());
            
            if (operacionMatematica == "SUMAR")
            {
                Sumar(nOperacion);
            }
            else if (operacionMatematica == "MULTIPLICAR")
            {
                Multiplicar(nOperacion);
            }
            else
            {
                Console.WriteLine("Operacion Matematica no valida");
            }
            Console.ReadKey();
        }

        // Metodo de la tabla de Sumar
        static void Sumar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " + " + a + " = " + (Numero + a));
            }
        }

        // Metodo de la tabla de Multiplicar
        static void Multiplicar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " x " + a + " = " + (Numero * a));
            }
        }
    }
}
