using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados.EjemploNotificacion
{
    public class EjemploNotificacion
    {
        public static void CambiarColorConsola() // Este metodo es aceptado por el delegado, es decir, se lo puedo pasar
        // Porque el delegado declarado no devuelve nada y no recibe nada, al igual que este metodo declarado. 
        // Por lo tanto lo puede encapsular DelegadoDestinatario
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public static void Notificar() // Este metodo es aceptado por el delegado, es decir, se lo puedo pasar
        // Porque el delegado declarado no devuelve nada y no recibe nada, al igual que este metodo declarado. 
        // Por lo tanto lo puede encapsular DelegadoDestinatario 
        {
            Console.WriteLine("Se envio una notificacion");
        }
        public static void Notificar(int tiempoDeEspera)
        {
            Console.WriteLine($"Se envio una notificacion despues de {tiempoDeEspera} milisegundos...");
        }
        public static void EjecutarEjemplo()
        {
            Receptor carpinchoReceptor = new Receptor("Carpincho Receptor");
            Receptor lautiReceptor = new Receptor("Lauti");
            Receptor lucasReceptor = new Receptor("Lucas");


            // Aca se esta instanciando el delegado, es este caso en el main, podria ser en cualquier otro lado 

            // El delegado apunta al metodo "RecibirNotificacion" del objeto "carpinchoReceptor" (y solo ese) 
            // Es decir, encapsula tambien al objeto.
            // Delegado instanciado con new.
            DelegadoDestinatario delegadoConNew = new DelegadoDestinatario(carpinchoReceptor.RecibirNotificacion);
            Emisor.destinatarios.Add(delegadoConNew);

            // Las dos formas de instanciar un delegado son iguales, con o sin "new Delegado()". 
            // Delegado Instanciado sin new.
            DelegadoDestinatario delegadoSinNew = lautiReceptor.RecibirNotificacion;
            Emisor.destinatarios.Add(delegadoSinNew); // Instancia de manera automatica

            // Si le paso la referencia a un metodo como argumento, se intancia el delegado automaticamente. 
            // Aca se aprendio como parasarlos directamente como argumentos de otro metodo. Como en los 4 casos que estan debajo
            Emisor.destinatarios.Add(lucasReceptor.RecibirNotificacion); 
            Emisor.destinatarios.Add(CambiarColorConsola);

            Emisor.destinatariosConTiempo.Add(new Perro().Ladrar);
            Emisor.destinatariosConTiempo.Add(Notificar);

            Emisor.ProducirNotificacion();
        }
    }
}
