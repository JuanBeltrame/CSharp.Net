  using System;

namespace SobrecargaConstructores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona();    
            
            Persona persona2 = new Persona("Juan",DateTime.Now, 33334545);

            Persona persona3 = new Persona("Juan",new DateTime(1998,5,9));

            Persona persona4 = new Persona("Ariel",new DateTime(1998,5,9),32713684);

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

            

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());  
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona4.Mostrar());

            Console.WriteLine(persona2 == persona4);
            
        }
    }
}
