using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados.EjemploNotificacion
{
    public class Receptor
    {
        string nombre;

        public Receptor(string nombre)
        {
            this.nombre = nombre;
        }

        public void RecibirNotificacion()
        {
            Console.WriteLine($"Yo {nombre} Recibi una notificacion a las {DateTime.Now}");
        }
    }
}
