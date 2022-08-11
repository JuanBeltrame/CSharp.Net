using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaConstructores
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private long dni;

        public Persona()
        {
            nombre = string.Empty; // Esto representa un string Vacio
            fechaNacimiento = new DateTime(1990, 1, 1);
            dni = -1;
        }
        public Persona(string nombre) : this() // El :this va a llamar primero al otro constructor
        {
            this.nombre = nombre;
        }
        public Persona(string nombre, DateTime fechaNac) : this(nombre)
        {
            this.fechaNacimiento = fechaNac;
        }
        public Persona(string nombre, DateTime fechaNacimiento, long dni) : this(nombre, fechaNacimiento)
        // El : this es una forma de llamar al constructor dentro de una misma clase
        {
            this.dni = dni;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento.ToString()}");
            sb.AppendLine($"DNI: {dni}");

            return sb.ToString();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1 is not null && p2 is not null)
                return p1.nombre == p2.nombre;
            return false;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public static implicit operator long(Persona p1)
        {
            return p1.dni;
        } 

        public static explicit operator string(Persona p1)
        {
            return p1.nombre;
        }
    }
}
