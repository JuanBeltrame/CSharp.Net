namespace LibreriaParaCicloFor
{
        #region Enunciado
        /*
        Hacer un programa que solicite el ingreso de 10 números enteros 
        y que muestre el mayor de ellos por pantalla. 
        Solo se debe emitir un solo valor por pantalla. 
        Que muestre además, de todos los números ingresados cuál fue el menor de ellos.
         */
        #endregion

    public sealed class Ejercicio01_2
    {

        private static void Bienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se ingreso al ejercicio: {0}", nameof(Ejercicio01_2));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void CargaYCalculo()
        {
            string texto;
            int numero;
            int maximo = 0;
            int minimo = 1000;

            Console.WriteLine("Ingresar 10 numeros: ");

            for (int i = 0; i < 10; i++)
            {
                texto = Console.ReadLine();
                numero = int.Parse(texto);

                if (numero > maximo)
                    maximo = numero;
                if (numero < minimo)
                    minimo = numero;

            }
            Console.WriteLine("El mayor numero ingresado ha sido el numero: {0}", maximo);
            Console.WriteLine($"El menor numero ingresado ha sido el numero: {minimo}");

            
        }
        private static void SalirDelPrograma()
        {
            char desicion;

            Console.WriteLine();
            do
            {
                Console.WriteLine("Desea salir del programa? y/n");
                desicion = char.Parse(Console.ReadLine());
            } while (desicion != 'n' && desicion != 'y');

            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            while (desicion == 'n')
            {
                CargaYCalculo();
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Desea salir del programa? y/n");
                    desicion = char.Parse(Console.ReadLine());

                } while (desicion != 'n' && desicion != 'y');
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
            }
        }
        private static void Mostrar()
        {
            Bienvenida();
            CargaYCalculo();
            SalirDelPrograma();
        }
        public static void DondeSucedeLaMagia()
        {
            Mostrar();
        }
    }
}