using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion4
{
    internal class Usuario
    {
        public string nombre;
        string password;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public bool CheckearPw(string password)
        {
            return this.password == password;
        }

        public string GetUser() // Encapsular
        {
            return this.nombre;
        }
    }
}
