using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegados.EjemploNotificacion
{
    public static class Emisor
    {
        public static Random random = new Random();
        public static List<DelegadoDestinatario> destinatarios = new List<DelegadoDestinatario>();
        public static List<DelegadoDestinatarioConTiempo> destinatariosConTiempo = new List<DelegadoDestinatarioConTiempo>();

        // Usando Delegados Predefinidos // Se podria reemplazar de la siguiente manera // En este caso Action
        public static List<Action> destinatariosOpcionEjemplo = new List<Action>();
        public static List<Action<int>> destinatariosConTiempoOpcionOtroEjemplo = new List<Action<int>>();


        public static void ProducirNotificacion()
        {
            destinatarios.Where(ObtenerCriterioParaFiltrar).ToList();
            destinatarios.Sort(new Comparison<DelegadoDestinatario>(Comparar)); // Forma Larga de Instanciar un delegado


            destinatarios.Sort(Comparar); // Forma Corta de Hacerlo 
                                          // Si lo paso directo, se intancia por detrar el delegado, se instancia automaticamente, implicitamente


            Console.WriteLine("Produciendo Notificacion!");

            foreach (DelegadoDestinatario delegadoDestiantario in destinatarios)
            {
                int tiempo = random.Next(2000, 5000);
                Thread.Sleep(tiempo);
                // Notificar!! 
                // Dos formas de invocar/usar la instancia del delgado.
                // Hay 2 formas de invocarlo, con Invoke o directamente con los parentesis
                //delegadoDestiantario.Invoke();
                delegadoDestiantario(); // Aca invoca la referencia, lo usa!, lo usa  la clase emisor!  
                                        // Esta almacenado en su lista de delegados   
            }

            foreach (DelegadoDestinatarioConTiempo delegadoDestiantarioConTiempo in destinatariosConTiempo)
            {
                int tiempo = random.Next(2000, 5000);
                Thread.Sleep(tiempo);

                // Dos formas de invocar/usar la instancia del delgado.
                delegadoDestiantarioConTiempo.Invoke(tiempo);
                delegadoDestiantarioConTiempo(tiempo);
            }
        }

        // Dos Casos de usos reales para filtrar y para comparar usando el metodo where y el metodo sort
        // que recibien como argumento un delegado y lo usan. el sort para ordenar y el where para filtrar
        public static bool ObtenerCriterioParaFiltrar(DelegadoDestinatario delegadoDestinatario)
        {
            return delegadoDestinatario.Method.Name.StartsWith('N') || delegadoDestinatario.Method.Name.StartsWith('L');
        }
        public static int Comparar(DelegadoDestinatario elemento1, DelegadoDestinatario elemento2)
        {
            return string.Compare(elemento1.Method.Name, elemento2.Method.Name);
        }
        public static int Comparar(Action<int> elemento1, Action<int> elemento2)
        {
            return string.Compare(elemento1.Method.Name, elemento2.Method.Name);
        }
    }
}
