using System;

 /*
 Un sistema que ingrensado usuario y contrasena
 me diga USUARIO LOGEADO si es correcto, y sino es correcto, 
 ACCESO DENEGADO
 */

namespace Logica
{
    public class Usuario
    {
        public string nombre;
        private string contrasenia;
        

        public Usuario(string nombre, string constrasenia)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
            else
            {
                this.nombre = "Sin nombre";
            }
            
            this.contrasenia = constrasenia;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public bool ComprobarPass(string pass)
        {
            return contrasenia == pass;
        }

        public void ModificarContra(string pass)
        {
            this.contrasenia = pass;
        }
    }
} 
