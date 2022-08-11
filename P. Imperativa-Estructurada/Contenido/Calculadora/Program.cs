using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0: Declarar las variables

            // Tipo de dato: int, float, char, bool
            // Esta es una Forma para declarar varias variables en una misma linea
            int n1, n2;
            // Lo mismo se puede hacer en 2 lineas: 
            // int n1;  
            // int n2; 
            // float n3; 
            int resultado;

            // Asignar valores a una variable

            // n1 = 7;
            // n2 = 9; 




            // Paso 1: pedir valores.

            //Console.WriteLine("Los valores de las variables son las siguientes: "); 
            // Console.WriteLine("N1 tiene: " +n1);
            // Console.WriteLine("N2 tiene: " +n2);

            Console.WriteLine("Ingrese un numero: ");
            // Console.ReadLine();

            // Aca: Lo que capturo lo asigno en la variable N1, de la siguiente manera: 
            // int.Parse le doy todo lo que devuelve el Readline
            // int.Parse le dice al programa: que todo lo que devuelta el Console.Realine va a ser un numero
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Ingrese otro: ");
            // n2 = int.Parse(Console.ReadLine());





            // Paso 2: realizar calculo.
            // + - * / %
            resultado = n1 + n2;




            // Paso 3: emitir resultado.
            Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
