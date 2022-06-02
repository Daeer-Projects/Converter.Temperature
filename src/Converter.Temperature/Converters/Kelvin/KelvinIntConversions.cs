namespace Converter.Temperature.Converters.Kelvin
{
using System;
    using Celsius;

    internal static class KelvinIntConversions
    {
        /// <summary>
        /// The kelvin to celsius conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int KelvinToCelsius(int input)
        {
            const int maxValue = int.MaxValue - 273;
            const int minValue = int.MinValue + 273;
            if (input < minValue || input > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            var celsiusTemp = input - 273;
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
        public static int KelvinToFahrenheit(int input)
        {
            var celsiusTemp = KelvinToCelsius(input);
            var fahrenheitTemp = CelsiusIntConversions.CelsiusToFahrenheit(celsiusTemp);
            return fahrenheitTemp;
        }

        /// <summary>
        /// The kelvin to kelvin conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int KelvinToKelvin(int input)
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
        public static int KelvinToGas(int input)
        {
            var celsiusTemp = KelvinToCelsius(input);
            var gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
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
        public static int KelvinToRankine(int input)
        {
            var rankineTemp = input * 9 / 5;
            return rankineTemp;
        }
    }
}
