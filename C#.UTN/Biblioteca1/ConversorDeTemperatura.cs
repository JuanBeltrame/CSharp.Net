using System;

namespace Biblioteca1
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
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
