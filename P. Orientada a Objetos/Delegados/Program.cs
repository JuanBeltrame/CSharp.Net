using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegados.EjemploNotificacion;
using Delegados.EjemploFiltrado;

namespace Delegados
{
    public class Program
    {
        static void Main()
        {
            EjemploNotificacion.EjemploNotificacion.EjecutarEjemplo();
            EjemploFiltrado.EjemploFiltrado.EjecutarEjemplo();
        }
    }
}
