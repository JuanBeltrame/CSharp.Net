  using System;

namespace SobrecargaConstructores
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Aula aula = new Aula();

            //if (persona1 + aula)
            //{
            //    Console.WriteLine("Agregada");
            //}
            //if (persona2 + aula)
            //{
            //    Console.WriteLine("Agregada");
            //}

            aula += persona1;

            aula = aula + persona2;

            long dni = persona1;

            string dni1 = (string)persona1;



            

        }
    }
}
