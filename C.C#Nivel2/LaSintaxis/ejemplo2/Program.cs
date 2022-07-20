using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales
            // IF 
            //Switch

            int a = 10;
            int b = 12;

            // (Operaciones Relacionales) == != > < >= <= 

            // (Operadores Logicos) 
            // (Negado)!
            // (And) &&
            // (Or) || 

            if (a == b && b != 10 || !(a == 20))
            {
                Console.WriteLine("Se cumple...");
                if (a != 9)
                {

                }
            }
            else if (a==15)
            {
                Console.WriteLine("No se cumple"); 
            }
            else if (b !=a)
            {

            }
            else if (b < 10)
            {

            }

            switch (a)
            {
                case 1:
                     // instr
                    break;
            }
        }
    }
}
