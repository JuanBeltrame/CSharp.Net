using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion03._1
{
    public static class Funciones
    {
        /// <summary>
        /// Este nombre devuelve el nombre de la facultad UTN
        /// </summary>
        /// <returns> devuelve un string</returns>
        public static string NombreApp()
        {
            return "Universidad Tecnologica Nacional";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="division"> Que division Recibe </param>
        /// <returns></returns>
        public static int CantidadAlumnos(string division)
        {
            if (division == "A")
                return 10;
            else if (division == "B")
                return 20;
            else 
                return 500;
            
        }
    }
}
