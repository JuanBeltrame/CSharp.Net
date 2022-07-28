using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeCondicionales
{
    public class EjemplosConIF
    {
        public static void EjemploDeIf1()
        {
            int edad = 35;

            if (edad > 30)
                Console.WriteLine("30 off");           
            else if (edad >20 )
                Console.WriteLine("21 off");
            else if (edad == 18)
                Console.WriteLine("10 off");
            else
                Console.WriteLine("5 off");

            Console.WriteLine("Fin del programa ");
        }

        public static void EjemploContador2()
        {
            int contador = 0;

            int edad1 = 20;
            int edad2 = 30;
            int edad3 = 30       ;

            if (edad1 > 18)
                contador++;
            if (edad2 > 18)
                contador++;
            if (edad3 > 18)
                contador++;
            
            
            // Opciones para escribir Contadores 

            // contador = contador + 1;

            // contador++; Suman uno

            // Contador--; Restan uno

            Console.WriteLine("El conteo es: "+ contador);
            
        }
    }
}
