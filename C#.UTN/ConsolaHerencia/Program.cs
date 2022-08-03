using System;
using System.Collections.Generic;
using Entidades;

namespace ConsolaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Lautaro", "Galarza", 32713684);
            Profesor prof1 = new Profesor("Programacion II", "Beltrame", 32713684, "Juan");
            Estudiante est1 = new Estudiante(p1, 46083);

            Persona p2 = prof1; // Se guardo en un objeto de tipo persona, una referencia de profesor.
                                // Por el principio de sustitucion de Liskov

            // Esto no implica que se tenga perdida de informacion
            // A simple vista no voy a poder usar los metodos de profesor, 
            // En memoria Persona p2, sigue siendo una instancia de tipo profesor, sigue teniendo una referencia tipo profesor.
            // Por lo cual por medio de un casteo, se puede recuperar esa informacion.


            List<Persona> personas = new List<Persona>();
            personas.Add(p1);
            personas.Add(prof1);
            personas.Add(est1);

            //foreach (var item in personas)
            //{
            //    Console.WriteLine(item.MostrarPersona());
            //}

            foreach (Persona item in personas)
            {
                if (item is Profesor)
                {
                    Profesor profe = (Profesor)item;
                    Console.WriteLine(profe.Corregir());
                }
                else if (item is Estudiante)
                {
                    Estudiante profe = (Estudiante)item;
                    Console.WriteLine(profe.Estudiar());
                }

            }

            //Console.WriteLine(p1.MostrarPersona());
            //Console.WriteLine(est1.MostarAlumno());

        }
    }
}
