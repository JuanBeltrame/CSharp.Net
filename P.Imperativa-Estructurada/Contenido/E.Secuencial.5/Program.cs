using System;

namespace E.Secuencial._5
{
    #region Enunciado
    /*
    Hacer un programa para ingresar por teclado las tres notas de
    examenes de un alumno y luego calcule y emita por pantalla el promedio final.
    */
    #endregion

    internal class Program
    {
        private static float CargarDatos()
        {
            float nota1, nota2, nota3;
            float sumaDeNotas;

            Console.WriteLine("Ingrese la primera nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercerca nota: ");
            nota3 = float.Parse(Console.ReadLine());

            sumaDeNotas = nota1 + nota2 + nota3;

            return sumaDeNotas;
        }
        private static float SumaDeNotas()
        {
            return CargarDatos();
        }
        private static float CalculaPromedio()
        {
            float promedio;

            promedio = SumaDeNotas() / 3;

            return promedio;
        }
        private static void MostarPromedio()
        {
            Console.WriteLine($"El promedio es {CalculaPromedio().ToString("0.00")}");
        }
        private static void DondeLaMagiaSucede()
        {
            MostarPromedio();
        }
        static void Main(string[] args)
        {
            DondeLaMagiaSucede();
        }
    }
}
