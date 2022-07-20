using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploUnivesal
{
    internal class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >=4 && this.notaSegundoParcial >=4)
            {
                return random.Next(6, 11);
            }
            return -1;
            
        }
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + (float)this.notaSegundoParcial) / 2;   
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = CalcularNotaFinal();
            sb.AppendLine($"Nombre: {this.nombre}, Apellido: { this.apellido}, Legajo: {this.legajo}");
            sb.AppendLine($"Primer Parcial : {this.notaPrimerParcial}, Segundo Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio : {this.CalcularPromedio()}");

            if (notaFinal!=-1)
            {
                sb.AppendLine($"Final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString ();  
        }
    }
}
