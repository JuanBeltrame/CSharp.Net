using System;

namespace Presentacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            string nombreCompleto; // Asi se declara
            nombreCompleto = "Juan Beltrame"; // Asi se asigna  
            string n = "Hello Word " + nombreCompleto + "!";  // Declarar y asignar en la misma linea 
            Console.WriteLine(nombreCompleto); // mostrar el mensaje por consola 

            // Tipo de valor, por que es una (estructura)
            int numero = 12;
            CambiarValor(numero);
            Console.WriteLine(numero);

            // Tipo de Referencia, porque es una(clase)
            Persona persona = new Persona()
            {
                Nombre = "Juan Beltrame"
            };
            CambiarValor(persona);
            Console.WriteLine(persona.Nombre);


            /* Se esta guardando un string, por lo tanto producto va a ser de tipo string 
             por mas no se escriba el tipo de dato explicitamente, lo esta infiriendo */
            var producto = "Alfajor capitan del Espacio";
            Console.WriteLine("{0} es de tipo {1} ", nameof(producto), producto.GetType().Name);
             

            // Formato Compuesto: 
            string nombre = "Jb";
            int edad = 35;
            Console.WriteLine("Soy {0} y tengo {1} anios.", nombre, edad);

            // Trabajando con la consola 
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombrecito = Console.ReadLine();
            Console.WriteLine(" Ingrese un precio: ");
            string precioString = Console.ReadLine();

        }
        static void CambiarValor(Persona persona)
        {
            persona.Nombre = "Mauricio Verona";
        }
        static void CambiarValor(int numero)
        {
            numero = 90; 
        }
        public class Persona
        {
            public string Nombre { get; set; }
        }
    }
}
