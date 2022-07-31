using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    // Clase creada dentro de otra clase, solo para que sea mas facil de visualizar. 
    public class Animal
    {
        public virtual string EmitirSonido()
        {
            return "RoaaaaR";
        }
    }
    public class Perro : Animal
    {
        public override string EmitirSonido()
        {
            return "woof!!!";
        }
    }
    public class Cachorro : Perro
    {
    }
    public class Carpincho : Animal
    {
        public override string EmitirSonido()
        {
            return "Viva la revolucion carpincha!";
        }
    }
}
