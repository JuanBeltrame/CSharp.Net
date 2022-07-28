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

        /*
        Formas de Calcular Porcentajes: 
        100 * 1 = 100;
        100 * 1.32 = 132
        100 * 1.5 = 150
        100 * 0.90 = Aca, obtengo el valor con un 10% de descuento
        100 - 100 * 0.90 = Esto es otra opcion, y el resultado que voy a obtener es el 10%
        100 * 0.10 = De esta forma voy a obtener el 10% del 100, o otra forma de verlo, seria el 100 con un 90% de descuento.
        */

        private const float sueldoFijo = 15000;
        private const float porcentajeComision = 0.05F;   

        private static float TotalFactuado()
        {
            float totalFacturado;
            
            Console.WriteLine("Ingrese el total facturado");
            totalFacturado = float.Parse(Console.ReadLine());

            return totalFacturado;
  
        }
        private static float CalcularComision()
        {
            float comision;

            comision = TotalFactuado() * porcentajeComision;

            return comision;
        }
        private static float CalculaSueldo()
        {
            float sueldoFinal;

            sueldoFinal = CalcularComision() + sueldoFijo;

            return sueldoFinal;
        }
        private static void Mostrar()
        {
            Console.WriteLine($"El Sueldo total a pagar es:{CalculaSueldo()}");
        }
        private static void DondeSucedeLaMagia()
        {
            Mostrar();
        }

        static void Main(string[] args)
        {
            DondeSucedeLaMagia();
        }
    }
}
