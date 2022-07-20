using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Persona
            Persona p1 = new Persona(); // Instanciar un Objeto Persona

            p1.Nombre = "Juan Beltrame";
            Console.WriteLine("El nombre de esta persona es: " + p1.Nombre);

            p1.setEdad(20);
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            p1.Sueldo = 80.000F;
            Console.WriteLine("El sueldo de de juan es de " + p1.Sueldo);



            // Botella
            Botella b1 = new Botella("Rojo","Plastico"); // Instanciar un Objeto Botella
            b1.Capacidad = 200;
            Console.WriteLine("La Capacidad de mi botella es de: " + b1.Capacidad);

            b1.Color = "Celeste";
            Console.WriteLine("El color de la botella es: " + b1.Color);

            b1.Material = "Carton";
            Console.WriteLine("El Colo de mi botella es: " + b1.Material);

            // Perro 
            Perro Perro1 = new Perro(); // Instanciar un Objeto Perro
            Perro1.Nombre = "Luna";
            Console.WriteLine("El nombre de mi Perro es: " + Perro1.Nombre);

            Perro1.Color = "Blanco";
            Console.WriteLine("El colo de" + Perro1.Nombre + " es: " + Perro1.Color);

            Perro1.Origen = "de la calle";
            Console.WriteLine("El origen de mi perro es : " + Perro1.Origen);


            Console.ReadKey();
        }
    }
}
