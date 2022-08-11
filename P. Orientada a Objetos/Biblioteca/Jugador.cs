using System;
using System.Text;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioDeGoles;
        private int totalGoles;

        private Jugador()
        {

        }  

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
            
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) 
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            partidosJugados = totalPartidos;    
        } 

        public float GetPromedioGoles()
        {
            promedioDeGoles = (float)totalGoles / partidosJugados;
            return promedioDeGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Cantidad de partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total de Goles: {totalGoles}");
            sb.AppendLine($"Promedio de Goles: {GetPromedioGoles()}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1 is not null &&  jugador2 is not null)
            {
                return jugador1.dni == jugador2.dni;
            }
            return false; 
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
           return !(jugador1 == jugador2);  
        }
    }
}