using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        // private int codArticulo;
        // private float precio;
        private int codidoMarca;

        // Forma Corta de escribir propiedades
        public int CodigoArticulo { get; set; }
        public int Precio { get; set; }
        public int CodigoMarca
        {
            get { return codidoMarca; }
            set 
            { 
                if (value > 0 && value < 11)
                {
                    codidoMarca = value;
                }
                else
                {
                    codidoMarca = -1;   
                }
            }
        }

    }
}
