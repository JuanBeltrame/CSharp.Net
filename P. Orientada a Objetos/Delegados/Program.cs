using System;
using System.Collections.Generic;
using System.Threading;

namespace Delegados
{
    internal class Program
    {
        static void Main()
        {
            Receptor carpinchoReceptor = new Receptor("Carpincho Receptor");
            Receptor lautiReceptor = new Receptor("Lauti");

            Emisor.destinatarios.Add(carpinchoReceptor.RecibirNotificacion);
            Emisor.destinatarios.Add(lautiReceptor.RecibirNotificacion);

            Emisor.ProducirNotificacion();
        }

        public delegate void DelegateDestinatario();

        public static class Emisor
        {
            public static Random random = new Random();
            public static List<DelegateDestinatario> destinatarios = new List<DelegateDestinatario>();

            public static void ProducirNotificacion()
            {
                Console.WriteLine("Produciendo Notificacion!");
                
                foreach (DelegateDestinatario delegadoDestiantario in destinatarios)
                {
                    Thread.Sleep(random.Next(2000, 5000));
                    //delegadoDestiantario.Invoke();
                    delegadoDestiantario();
                }
            }
        }

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
}
