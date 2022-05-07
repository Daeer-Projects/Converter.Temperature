namespace Converter.Temperature.Converters.Rankine
{
    using Celsius;

    internal static class RankineFloatConversions
    {
        /// <summary>
        /// The rankine to rankine conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float RankineToRankine(float input)
        {
            return input;
        }

        /// <summary>
        /// The rankine to celsius conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float RankineToCelsius(float input)
        {
            var rankineTemp = (input - 491.67f) * 5 / 9;
            return rankineTemp;
        }

        /// <summary>
        /// The rankine to fahrenheit conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float RankineToFahrenheit(float input)
        {
            var rankineTemp = input - 459.67f;
            return rankineTemp;
        }

        /// <summary>
        /// The rankine to kelvin conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float RankineToKelvin(float input)
        {
            var rankineTemp = input * 5 / 9;
            return rankineTemp;
        }

        /// <summary>
        /// The rankine to gas conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static float RankineToGas(float input)
        {
            var celsiusTemp = RankineToCelsius(input);
            var gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }
    }
}
