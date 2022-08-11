using System; // System es un namespace

namespace Aplicacion03._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nombreApp = Funciones.NombreApp();
            int cant = Funciones.CantidadAlumnos("A");

            Console.WriteLine("Ingrese Cantida de alumnos");

            int cantAlumnos;
            cantAlumnos =  int.Parse(Console.ReadLine());

            // cantAlumnos = int.TryParse(Console.ReadLine());

            // int.TryParse("Que string convierto", out "Si pudo convertir, donde lo guarda");

            //                               "Que String conviero"   "Si pudo convertir, donde lo guarda");
            bool pudoConvertir = int.TryParse(Console.ReadLine(), out cantAlumnos);

            // Caso feliz: 
            //     true                                   "22"           22
            //bool pudoConvertir = int.TryParse(Console.ReadLine(), out cantAlumnos);

            // Caso NO feliz: 
            //     false                                 "pepe"           0
            // pudoConvertir = int.TryParse(Console.ReadLine(), out cantAlumnos);

            // Console.WriteLine(cantAlumnos);





            // Como se manejan Arrays en C#

            // Arrays en C# // 1ra Forma // de 0 a 4
            string[] arrayString1 = new string[5];

            arrayString1[0] = "Hola";
            arrayString1[1] = "2";
            arrayString1[2] = "3";
            arrayString1[3] = "4";
            arrayString1[4] = "5";



            // Abrir llaves y por cada elemento que uno complete, se va completando la pos. de Memoria
            // Arrays en C# // 2da Forma // Este seria un array de 4 posiciones // De 0 a 3
            string[] arrayString2 = { "Hola", "2", "holafd", "ioi"};



        }
    }
}

