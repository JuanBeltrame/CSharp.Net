using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor: Persona
    {
        public string catedra;

        public Profesor (string catedra, string apellido, long dni, string nombre):base(nombre,apellido,dni)
        {
            this.catedra = catedra;
        }

        public string Corregir()
        {
            return "Estoy Corrigiendo..."; 
        }
    }
}
