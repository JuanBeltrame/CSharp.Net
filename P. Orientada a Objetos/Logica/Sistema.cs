using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] usuariosRegistrados;
        // static Usuario miUsuario;
        static Sistema() // Constructor STATIC sistema
        {
            usuariosRegistrados = new Usuario[8];
            // miUsuario = new Usuario("Pepe","ASD123");
            CargarUsuariosHardcodeados();
        }

        private static void CargarUsuariosHardcodeados()
        {
            usuariosRegistrados[0] = new Usuario("Pepe", "asdd123");
            usuariosRegistrados[1] = new Usuario("Carola", "caro123");
            usuariosRegistrados[2] = new Usuario("Romeo", "miaumiau");
            usuariosRegistrados[3] = new Usuario("Jazmin", "rufosal123");
            usuariosRegistrados[4] = new Usuario("Juana", "rufruf01");
        }

        public static bool CrearNuevoUsuario(string nombre, string password)
        {
            // Que haya espacio
            // Que no exista

            usuariosRegistrados[5] = new Usuario(nombre, password);

            return true; 
        }

        // Aca recibo un nomnbre y un usuario, Quien me manda el nombre y el usuario?
        // El program...
        public static bool CheckearUsuario(string nombre, string pass)
        {
            if (string.IsNullOrEmpty(nombre.Trim()) || string.IsNullOrEmpty(pass.Trim()))
            {
                return false;
            }
            
            for (int i = 0; i < usuariosRegistrados.Length; i++)
            {
                if (usuariosRegistrados[i] != null)
                {
                    if (nombre.Trim().ToUpper() == usuariosRegistrados[i].GetNombre().Trim().ToUpper())
                    {
                        return usuariosRegistrados[i].ComprobarPass(pass);
                    }
                }
            }
            return true;
        }
    }
}


    