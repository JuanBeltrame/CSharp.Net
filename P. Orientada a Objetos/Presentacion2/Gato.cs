using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    /* Declaracion de Clases
    . Modificador de Visibilidad (Internal, etc...) 
    . La palabra reservada Class 
    . Nomnbre de la clase: Sustantivo en Singular, con la primera letra en Mayuscula
    */
    // CLASES
    internal class Gato
    {
        /* Declaracion de atributos          
        . Modificador de Acceso (Private, etc..)
        . Tipo de Dato 
        . Nombre del atributo: en camelCase
        */
        // ATRIBUTOS
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;

        //  METODO CONTRSTRUCTOR
        public Gato(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        /* Declaracion de Metodos: 
. Modificador de Visibilidad (public, private, etc..) 
. Si sera static o no static. Cuando no es static, la palabra no se escribe. 
. Tipo de retorno (void: no retorna nada) 
. Tipo de retorno (se debe indicar el tipo de dato a retornar) 
. Nombre del Metodo (Tiene que ser un Verbo) // los metodos se escriben en PascalCase
. El tipo de dato que tendra el parametro
. Entre parentesis van los parametros de Entrada (En caso que sea necesario) 
*/
        // METODOS
        public void AsignarNombreOpcion1(string nombre) // Opcion 1 
        {
            if (nombre is null)
            {
                this.nombre = "Sin nombre";
            }
            else
            {
                this.nombre = nombre;
            }

        }
        public void AsignarNombreOpcion2(string nombre )//Opcion 2
        {
            nombre = ""; 
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "Sin nombre";
            }
        }

        public void AsignarPesoOpcion1(double peso)
        {
           if (peso < 0)
            {
                peso = 0;
            }

            this.peso = peso;
        }
        public void AsignarPesoOpcion2(double nuevoPeso)
        {
            peso = nuevoPeso;
        }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del gato: ");
            sb.AppendFormat("Nombre del gato: {0} ", nombre);

            if (nombre is not null)
            {
                sb.AppendLine($"Nombre : {nombre.ToUpper()}");
            }
            else
            {
                sb.AppendLine("Sin nombrre");
            }
       
            // Strings Interpolados: es con el signo pesos adelante
            sb.Append($"Fecha de naciemnto: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($" Peso: {peso}");
            return sb.ToString();
        }
        public double ObtenerPeso()
        {
            return peso;
        }
    }
}
