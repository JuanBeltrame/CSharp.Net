using System;
using Presentacion;

namespace Presentacion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////   
            // INSTANCIO GARFIELD 
            Gato garfield = new Gato("Garfield", new DateTime(2018, 03, 28));
            // Invoco metodos de Instancia 
            garfield.AsignarPesoOpcion1(5);

            Console.WriteLine($"El peso es: {garfield.ObtenerPeso()}"); // Opcion a

            double pesoGarfield = garfield.ObtenerPeso(); // Opcion b

            Console.WriteLine($"El peso de Garfield es:{pesoGarfield}");

            Console.WriteLine(garfield.ObtenerDatos());
            Console.WriteLine(garfield.GetHashCode());


            ///////////////////////////////////////////////////////////////////////////////////////////////// 
            // INTANCIO FELIX
            Gato felix = new Gato("felix", new DateTime(2018, 03, 28));

            // Invoco metodos de Instancia 
            felix.AsignarPesoOpcion1(3);

            double pesoFelix = felix.ObtenerPeso();

            // Console.WriteLine --> Metodo estatico (de clase) No se necesita instanciar un objeto para invocarlo
            Console.WriteLine($"El peso de Felix es:{pesoFelix}");
            Console.WriteLine(felix.GetHashCode());


            ///////////////////////////////////////////////////////////////////////////////////////////////// 
            Gato garfield2 = new Gato("Garfield", new DateTime(2018, 03, 28));
            garfield2.AsignarPesoOpcion2(5);
            //Console.Clear();
            // GetHashCode es um metodo de insntacia que devuelve un codigo unico 
            // Para identificar a una insntancia en memoria.
            Console.WriteLine(garfield2.GetHashCode());

            // Operador == Por defecto compara si apuntan a la misma direccion de memoria (Son la misma instancia)
            // Da false porque no son el mismo objeto en memoria.
            Console.WriteLine("Son iguales? {0}", garfield == garfield2);

            // Da true porque son el mismo objeto en memoria.
            Console.WriteLine("Son iguales? {0}", garfield == garfield);

            // Equals es un metodo de instancia que sirve para comparar un objeto con otro
            // Por defecto, compara si son la misma instancia en memoria. 
            Console.WriteLine("Son iguales? {0}", garfield.Equals(garfield2));


            // Metodo estatico para comparar si dos objetos son la misma instancia en memoria. 
            Console.WriteLine(ReferenceEquals(garfield, garfield2));

            // GetHashCode devuelve un codigo unico para identificar a una instancia en memoria. 
            Console.WriteLine($"{nameof(garfield)}: {garfield.GetHashCode()}");
            Console.WriteLine($"{nameof(garfield2)}: {garfield.GetHashCode()}");


            ///////////////////////////////////////////////////////////////////////////////////////////////// 
            Gato garfield3 = garfield;
            // Da true porque a pesar de ser variables distintas, ambas variables guardan la referencia del mismo objeto new Gato Garfield
            // La cual vive en una direccion de memoria particular, y esto es lo que le digo a los tipos de referencia. 
            // Donde puedo tener n variables apuntando al la misma referencia. Es decir al mismo objeto.  
            Console.WriteLine("Son iguales? {0}", garfield == garfield3);
        }
    }
}
