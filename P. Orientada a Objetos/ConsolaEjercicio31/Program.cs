using System;
using PuestoDeAtencion_Biblioteca_;

namespace ConsolaEjercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Lautaro", 1);
            Cliente c2 = new Cliente("Muaricio", 2);
            Cliente c3 = new Cliente("Esteban", 2);
            Negocio n1 = new Negocio("Kioso-24");

            if (n1 + c1)
            {
                Console.WriteLine("Se agrego c1 a la cola");
            }
            if (!(n1 + c1))
            {
                Console.WriteLine("El cliente ya esta en la cola");
            }
            if (n1 + c3)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
            }
            while (~n1)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
            }
        }
    }
}
