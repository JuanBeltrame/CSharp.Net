using System;

namespace Aplicacion4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Usuario usuarioCaro = new Usuario("Caruchi", "JuanaJuana123");
            Usuario usuarioLauti = new Usuario("Lauti", "SuperPro123");

            // Opcion 1
            if (usuarioCaro.CheckearPw("pepepepe"))
            {
                Console.WriteLine("Caro Logueada");
            }
            else
            {
                Console.WriteLine("Raja de aca");
            }

            // Opcion 2
            if (usuarioCaro.CheckearPw("JuanaJuana123"))
            {
                Console.WriteLine($"{usuarioCaro.GetUser()} logeada");
            }
            
            /////////////////////////////////////////////////////////////////////////////////////////
            Galletita g1 = new Galletita("Vainilla", 300);
            Galletita g2 = new Galletita("Chocolate", 150);


            Galletita[] paqueteDeGalletitas = new Galletita[8]; 

            for (int i = 0; i < paqueteDeGalletitas.Length; i++)
            {
                paqueteDeGalletitas[i] = new Galletita("Vainilla", 300); 
            }
            if (paqueteDeGalletitas[0] == paqueteDeGalletitas[1])
            {

            }
            if (g1 == g2)
            {

            }
            if (paqueteDeGalletitas[0].GetSabor() == paqueteDeGalletitas[1].GetSabor())
            {

            }

        }
    }       
}           
            