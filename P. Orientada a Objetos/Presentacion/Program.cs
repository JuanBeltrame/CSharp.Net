using System;

namespace Presentacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            
            

            


            


            

            

            

            


           



            /* Se esta guardando un string, por lo tanto producto va a ser de tipo string 
             por mas no se escriba el tipo de dato explicitamente, lo esta infiriendo */
            var producto = "Alfajor capitan del Espacio";
            Console.WriteLine("{0} es de tipo {1} ", nameof(producto), producto.GetType().Name);
             

            

            // Trabajando con la consola 
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombrecito = Console.ReadLine();
            Console.WriteLine(" Ingrese un precio: ");
            string precioString = Console.ReadLine();

        }
        
        
        
    }
}
