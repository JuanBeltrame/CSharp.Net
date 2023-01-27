using System.Diagnostics;

namespace LibreriaParaCicloDoWhile
{
    #region Enunciado
    // Se dispone de un conjunto de números enteros positivos.
    // Determinar cuántos números al menos se deben sumar, desde el primero que ingresa en adelante,
    // para alcanzar un resultado que sea mayor que un número ingresado previamente.

    #endregion
    public class Ejercicio01_1
    {
        public static void CargaYCalculo()
        {
            int suma = 0;
            int cont = 0;
            int numero = 0;

            do
            {
                string texto = Console.ReadLine();
                numero = int.Parse(texto);

                cont++;
                suma += numero;
            }
            while (suma > numero);
            Console.WriteLine(cont);

        }
    }
}