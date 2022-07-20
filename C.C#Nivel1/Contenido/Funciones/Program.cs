using System;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aca va el codigo...
            // Funciones
            // Partes de la Funcion
            // Cabecera
            // 1. Tipo de Dato
            // 2. Nombre
            // 3. Opcional: Parametros
            // Cuerpo
            // Definicion/Logica
            // Opcional: retorno de valor/resultado

            // Opcion a
            int n = devolverUno();
            Console.WriteLine(n);

            // Opcion b
            devolverUno();
            Console.WriteLine(devolverUno());

            // Opcion c
            Console.WriteLine(devolverUno());

            EjemploFuncion1.MiFuncion1();
            EjemploFuncion1.MiFuncion2();
        }

        static int devolverUno()
        {
            int nro = 15;
            return nro;
        }
    }
}
