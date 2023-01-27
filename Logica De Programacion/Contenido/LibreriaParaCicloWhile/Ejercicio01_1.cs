using System.Runtime.ConstrainedExecution;

namespace LibreriaParaCicloWhile
{
    #region Enunciado
    // Hacer un programa para mostrar los números del 1 al 10.
    // No se debe realizar ningún pedido de datos. USANDO WHILE.
    #endregion
    public sealed class Ejercicio01_1
    {
        public static void CargaYCalculo()
        {
            int numero = 0;
            int contadorNumero = 0;

            while (numero < 10)
            {
                numero += 1;
                contadorNumero = numero;
                Console.WriteLine(contadorNumero);
            }
        }
    }
}