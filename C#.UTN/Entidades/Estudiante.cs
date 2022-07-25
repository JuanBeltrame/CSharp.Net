using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Estudiante : Persona
    {
        public int legajo;
        public List<string> materias;

        public Estudiante (int legajo, List<string> materias, long dni, string nomnbre, string apellido):this(new Persona((nombre,apellido,dni),legajo)
        {
            
        }

        public Estudiante (Persona persona, int legajo):base(persona.apellido, persona.nombre, persona.dni)
        {
            this.legajo = legajo;
            this.materias = materias;
        }
    }
}
