using Converter.Temperature.Converters.Celsius;
using System;

namespace Converter.Temperature.Converters.Fahrenheit
{
    internal static class FahrenheitIntConversions
    {
        /// <summary>
        /// The fahrenheit to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int FahrenheitToCelsius(int firstTemp)
        {
            var celsiusTemp = (firstTemp - 32d) * 5 / 9;
            if (celsiusTemp < int.MinValue || celsiusTemp > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(firstTemp), Constants.ValueOutOfRangeForType);
            }

            int celsiusTempLong = (int)Math.Round(celsiusTemp, 0, MidpointRounding.AwayFromZero);

            return celsiusTempLong;
        }

        /// <summary>
        /// The fahrenheit to fahrenheit conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int FahrenheitToFahrenheit(int firstTemp)
        {
            return firstTemp;
        }

        /// <summary>
        /// The fahrenheit to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int FahrenheitToKelvin(int firstTemp)
        {
            var celsiusTemp = FahrenheitToCelsius(firstTemp);
            var kelvinTemp = CelsiusIntConversions.CelsiusToKelvin(celsiusTemp);
            return kelvinTemp;
        }

        /// <summary>
        /// The fahrenheit to gas conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int FahrenheitToGas(int firstTemp)
        {
            var celsiusTemp = FahrenheitToCelsius(firstTemp);
            var gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }

        /// <summary>
        /// The fahrenheit to rankine conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int FahrenheitToRankine(int firstTemp)
        {
            var rankineTemp = firstTemp + 460;
            return rankineTemp;
        }
    }
}
