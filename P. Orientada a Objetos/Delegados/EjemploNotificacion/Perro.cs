using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados.EjemploNotificacion
{
    public class Perro
    {
        public void Ladrar(int tiempo)
        {
            Console.WriteLine($"Woof! {tiempo} milisegundos. Woof!");
        }
    }
}
