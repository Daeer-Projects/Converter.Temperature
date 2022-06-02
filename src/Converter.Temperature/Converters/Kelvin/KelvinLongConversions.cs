namespace Converter.Temperature.Converters.Kelvin
{
using System;
    using Celsius;

    internal static class KelvinLongConversions
    {
        /// <summary>
        /// The kelvin to celsius conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long KelvinToCelsius(long input)
        {
            const long maxValue = long.MaxValue - 273L;
            const long minValue = long.MinValue + 273L;
            if (input < minValue || input > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            var celsiusTemp = input - 273L;
            return celsiusTemp;
        }

        /// <summary>
        /// The kelvin to fahrenheit conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long KelvinToFahrenheit(long input)
        {
            var celsiusTemp = KelvinToCelsius(input);
            var fahrenheitTemp = CelsiusLongConversions.CelsiusToFahrenheit(celsiusTemp);
            return fahrenheitTemp;
        }

        /// <summary>
        /// The kelvin to kelvin conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long KelvinToKelvin(long input)
        {
            return input;
        }

        /// <summary>
        /// The kelvin to gas conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long KelvinToGas(long input)
        {
            var celsiusTemp = KelvinToCelsius(input);
            var gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }

        /// <summary>
        /// The kelvin to rankine conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long KelvinToRankine(long input)
        {
            var rankineTemp = input * 9 / 5;
            return rankineTemp;
        }
    }
}
