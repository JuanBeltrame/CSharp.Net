using System;

namespace Conversores
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
        /// <summary>
        /// Convierte una temperatura en grados celcius a grados kelvin
        /// </summary>
        /// <param name="temperaturaCelsius"> Temperatura en grados celsius a convertir.</param>
        /// <returns> Temperatura en grados Kelvin correspondiente al argumento proporcionado </returns>
        public static float ConvertirCelciusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;

            return temperaturaKelvin;
        }

        public static float ConvertirKelvinACelciud(float temperatuaKelvin)
        {
            float temperaturaCelsius = temperatuaKelvin - ceroAbsoluto;

            return temperaturaCelsius;
        }
    }
}
