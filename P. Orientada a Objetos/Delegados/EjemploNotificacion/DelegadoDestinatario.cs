using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados.EjemploNotificacion
{
    // Declaro el delegado dentro de un namespace
    // ya que es un tipo mas, como si declarara una clase. 

    // Este delegado representa metodos que no devuelven nada y no reciben nada
    public delegate void DelegadoDestinatario();

    // Este delegado representa metodos que no devuelven nada y reciben un entero
    public delegate void DelegadoDestinatarioConTiempo(int tiempo);



}
