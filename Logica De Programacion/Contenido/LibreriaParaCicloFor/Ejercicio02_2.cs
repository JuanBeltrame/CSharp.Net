using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParaCicloFor
{
    internal class Ejercicio02_2
    {
        public static void Mostrar()
        {
            Console.Write("hola\n"); // "/n" hace un salto de linea
            Console.Write("Que tal");
            Console.Write("\thola"); // "\t" hace un tab en el texto
            Console.Write("hola \\n"); // El contrabarra "\n" me lo muestra como texto al usar "\\", es decir que lo anula
            Console.Write(@"hola \n"); // "@" anula el "\n"
            Console.Write("hola que tal todo \"hola\" \n"); // para poner comillas dentro de strings, 
        }
    }
}
