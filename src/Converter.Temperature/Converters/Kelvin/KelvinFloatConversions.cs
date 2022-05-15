﻿namespace Converter.Temperature.Converters.Kelvin
{
    using Celsius;

    internal static class KelvinFloatConversions
    {
        /// <summary>
        /// The kelvin to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float KelvinToCelsius(float firstTemp)
        {
            var celsiusTemp = firstTemp - 273.15f;
            return celsiusTemp;
        }

        /// <summary>
        /// The kelvin to fahrenheit conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float KelvinToFahrenheit(float firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var fahrenheitTemp = CelsiusFloatConversions.CelsiusToFahrenheit(celsiusTemp);
            return fahrenheitTemp;
        }

        /// <summary>
        /// The kelvin to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float KelvinToKelvin(float firstTemp)
        {
            return firstTemp;
        }

        /// <summary>
        /// The kelvin to gas conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float KelvinToGas(float firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }

        /// <summary>
        /// The kelvin to rankine conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float KelvinToRankine(float firstTemp)
        {
            var rankineTemp = firstTemp * 9 / 5;
            return rankineTemp;
        }
    }
}
