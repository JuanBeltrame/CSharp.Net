using System;

namespace Ej._11_Validacion
{
    public static class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            if (valor >= min && valor <= max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
 