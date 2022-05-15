namespace Converter.Temperature.Converters.Kelvin
{
using System;
    using Celsius;

    internal static class KelvinIntConversions
    {
        /// <summary>
        /// The kelvin to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int KelvinToCelsius(int firstTemp)
        {
            const int maxValue = int.MaxValue - 273;
            const int minValue = int.MinValue + 273;
            if (firstTemp < minValue || firstTemp > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(firstTemp), Constants.ValueOutOfRangeForType);
            }

            var celsiusTemp = firstTemp - 273;
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
        public static int KelvinToFahrenheit(int firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var fahrenheitTemp = CelsiusIntConversions.CelsiusToFahrenheit(celsiusTemp);
            return fahrenheitTemp;
        }

        /// <summary>
        /// The kelvin to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int KelvinToKelvin(int firstTemp)
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
        public static int KelvinToGas(int firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
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
        public static int KelvinToRankine(int firstTemp)
        {
            var rankineTemp = firstTemp * 9 / 5;
            return rankineTemp;
        }
    }
}
