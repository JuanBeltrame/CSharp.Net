namespace LibreriaParaCicloFor
{
    public class Ejercicio01_1
    {
        #region Enunciado
        /*
        Hacer un programa que solicite el ingreso de 10 numeros enteros y
        que muestre el mayor de ellos por pantalla. 
        Solo se debe emitir un solo valor por pantalla. 
         */
        #endregion
        public static void CargaYCalculo()
        {
            string texto;
            int numero;
            int maximo = 0;

            Console.WriteLine("Ingresar 10 numeros: ");

            for (int i = 0; i < 10; i++)
            {

                texto = Console.ReadLine();
                numero = int.Parse(texto);

                if (numero > maximo)
                    maximo = numero;
            }

            Console.WriteLine("El mayor numero ingresado ha sido el numero: {0}", maximo);
        }
    }
}