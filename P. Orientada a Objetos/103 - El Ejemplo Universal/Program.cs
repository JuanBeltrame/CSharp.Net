using System;
using EjemploUnivesal;

namespace EjemploUnivesal

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "El Ejemplo Universal";

            Estudiante e1 = new Estudiante("Galarza", "12345", "Nombre");
            Estudiante e2 = new Estudiante("Prieto", "12346", "Esteban");
            Estudiante e3 = new Estudiante("Cerizza", "12347", "Mauricio");

            e1.SetNotaPrimerParcial(6);
            e1.SetNotaSegundoParcial(6);

            e2.SetNotaPrimerParcial(7);
            e2.SetNotaSegundoParcial(8);

            e3.SetNotaPrimerParcial(3);
            e3.SetNotaSegundoParcial(4);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}
