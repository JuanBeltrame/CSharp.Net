using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PuestoDeAtencion_Biblioteca_
{
    internal class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2,
        }

        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            numeroActual = 0; 
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto; 
        }

        public static int NumeroActual
        {
            get
            {   
                numeroActual++;
                return numeroActual;
            }
        }
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
