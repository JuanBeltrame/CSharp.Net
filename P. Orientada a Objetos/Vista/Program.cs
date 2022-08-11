using System;
using Biblioteca;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(11,"Equipo");

            Jugador jugador = new Jugador(1234, "Lauti", 3, 2);
            Jugador jugador2 = new Jugador(177234, "Lucas", 6, 2);
            Jugador jugador3 = new Jugador(1254535454, "Federico", 7, 2);
            Jugador jugador4 = new Jugador(123544, "Esteban", 6, 2);

            AgregarJugador(equipo, jugador); // Se tiene que agregar
            AgregarJugador(equipo, jugador2); // No Se tiene que agregar
            AgregarJugador(equipo, jugador3); // Se tiene que agregar
            AgregarJugador(equipo, jugador4); // No Se tiene que agregar por capacidad 
        }

        static void AgregarJugador(Equipo equipo, Jugador jugador)
        {
            if (equipo + jugador)
            {
                Console.WriteLine($"Jugador agregado: {jugador.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar el jugador: {jugador.MostrarDatos()}");
            }
        }
    }
}


