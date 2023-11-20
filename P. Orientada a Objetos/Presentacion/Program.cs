using System;

namespace Presentacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            
            

            


            


            

            

            // Tipo de valor, por que es una (estructura)
            int numero = 12;
            CambiarValor(numero);
            Console.WriteLine(numero);

            // Ejemplo usando ref
            int otroNumero = 12;
            CambiaValorusanadoRef(ref otroNumero);
            Console.WriteLine(otroNumero);

            // Tipo de Referencia, porque es una(clase)
            Persona persona = new Persona()
            {
                Nombre = "Juan Beltrame"
            };
            CambiarValor(persona);
            Console.WriteLine(persona.Nombre);


            // Los valores por defecto de los TIPOS DE VALOR
            // Para los numericos el valor por defecto es 0
            sbyte numero01 = 0;
            byte numero02 = 0;
            short numero03 = 0;
            ushort numero04 = 0;
            int numero05 = 0;
            long numero06 = 0;
            ulong numero07 = 0;
            float numero08 = 0;
            double numero09 = 0;
            decimal numero10 = 0;

            // Para los booleanos el valor por defecto es false
            bool verdadOfalso = false;

            // Para lo char es un espacio vacio: ' '
            char caracter01 = ' ';

            //--------------------------------------------------
            // Los valores por defecto de los TIPOS DE REFERENCIA van a ser null
            Persona persona1 = null;
            string palabras = null;
            object cualquierObjeto = null;


           



            /* Se esta guardando un string, por lo tanto producto va a ser de tipo string 
             por mas no se escriba el tipo de dato explicitamente, lo esta infiriendo */
            var producto = "Alfajor capitan del Espacio";
            Console.WriteLine("{0} es de tipo {1} ", nameof(producto), producto.GetType().Name);
             

            

            // Trabajando con la consola 
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombrecito = Console.ReadLine();
            Console.WriteLine(" Ingrese un precio: ");
            string precioString = Console.ReadLine();

        }
        static void CambiarValor(Persona persona)
        {
            persona.Nombre = "Mauricio Verona";
        }
        static void CambiarValor(int numero)
        {
            numero = 90;
        }

        static void CambiaValorusanadoRef(ref int numero)
        {
            numero = numero * 2;
        }
        public class Persona
        {
            public string Nombre { get; set; }
        }
    }
}
