using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParaCicloFor
{
    #region Enunciado
    // Se leen de a uno por vez 25 valores numéricos.Calcular y exhibir el cuadrado de cada uno de ellos.
    #endregion
    public class Ejercicio02_1
    {
        private void Bienvenida()
        {
            Console.WriteLine("Se ingreso al ejercicio {0}", nameof(Ejercicio02_1));
            Console.WriteLine();
        }

        private static void CargaYCalculo()
        {
            int numeroAlCuadrado;

            for (int i =0; i<25; i++)
            {
                numeroAlCuadrado = i * i;
                Console.WriteLine(numeroAlCuadrado);
            }
        }

        private static void Mostrar()
        {
            CargaYCalculo();
        }

        public static void DondeLaMagiaSucede()
        {
            Mostrar();
        }
    }
}
