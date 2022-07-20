using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        // Atributos
        private int edad;
        private float sueldo;
        private string nombre;

        // Metodo Set para Modificar o Asignar un nuevo valor al atributo
        public void setEdad(int e)
        {
            edad = e; // Modifico o Asigno un nuevo Valor 
        }

        // Metodo Get para Consultar el valor del atributo
        public int getEdad()
        {
            return edad; // Me Retorna la edad
        }

        // Propiedades
        public float Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


    }
}
