using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Primer lote con 10 registros de productos, cada uno tiene: 
            - Codigo Articulo (3 digitos no correlativos)
            - Precio 
            - Codigo de Marca (1 al 10)

            Segundo lote con las ventas de la semana. Cada venta tiene:
            - Codigo Articulo 
            - Cantidad 
            - Codigo Cliente (1 al 100) 

            Este lote corta con Codigo de cliente cero. 
                    
             */

            Articulo[] articulos = new Articulo[10];
            //Aca le asigno el valor a un solo articulo
            articulos[3].CodigoMarca = 6;

            // Para cargar todos los Articulos
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese los datos del producto: ");
                Console.WriteLine("Codigo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[i].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10) ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }

        }
    }
}
