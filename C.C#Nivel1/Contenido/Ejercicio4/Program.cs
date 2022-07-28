using System;

namespace Ejercicio4
{
    /*
    4. Una casa de computacion paga a sus empleados un sueldo fijo de ARS15000,
    mas, una comision del 5% sobre el total facturado por cada empleado.

    Hacer un programa para ingresar el total facturado por un empleado y que
    luego calcule y emita por pantalla el sueldo total o cobrar por el mismo. 
    */
    internal class Program
    {
        // Sueldo fijo: $15000
        // 5% de comision sobre le total facturado

        public static void xxx()
        {
            float totalFacturado;
            Console.WriteLine("Ingrese el total facturado");
            totalFacturado = float.Parse(Console.ReadLine()); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
