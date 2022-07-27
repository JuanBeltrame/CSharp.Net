using System;

namespace Ej._11_Validacion
{
    public static class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max; // Expresion Logica, que devuelve un valor booleano.
        }
    }
}
