namespace Converter.Temperature.Converters.Kelvin
{
using System;
    using Celsius;

    internal static class KelvinLongConversions
    {
        /// <summary>
        /// The kelvin to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long KelvinToCelsius(long firstTemp)
        {
            const long maxValue = long.MaxValue - 273L;
            const long minValue = long.MinValue + 273L;
            if (firstTemp < minValue || firstTemp > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(firstTemp), Constants.ValueOutOfRangeForType);
            }

            var celsiusTemp = firstTemp - 273L;
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
        public static long KelvinToFahrenheit(long firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var fahrenheitTemp = CelsiusLongConversions.CelsiusToFahrenheit(celsiusTemp);
            return fahrenheitTemp;
        }

        /// <summary>
        /// The kelvin to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long KelvinToKelvin(long firstTemp)
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
        public static long KelvinToGas(long firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
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
        public static long KelvinToRankine(long firstTemp)
        {
            var rankineTemp = firstTemp * 9 / 5;
            return rankineTemp;
        }
    }
}
