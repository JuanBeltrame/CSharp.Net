using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;


        private Equipo()
        {
            jugadores = new List<Jugador>(); // Instancio una lista
        }
        public Equipo( short cantidad, string nombre)
            : this()
        {
            this.nombre = nombre;
            cantidadDeJugadores = cantidad; 
        }

        public static bool operator + (Equipo equipo, Jugador jugador)
        {
            if(equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                foreach (Jugador jug in equipo.jugadores)
                {
                    if (jug == jugador)
                    {
                        return false;
                    }
                }
                equipo.jugadores.Add(jugador);
                
            }
            return true;
        }
    }
}