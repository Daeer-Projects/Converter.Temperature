namespace Converter.Temperature.Converters.Rankine
{
    using Celsius;

    internal static class RankineLongConversions
    {
        /// <summary>
        /// The rankine to rankine conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long RankineToRankine(long input)
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
        public static long RankineToCelsius(long input)
        {
            var rankineTemp = (input - 492L) * 5 / 9;
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
        public static long RankineToFahrenheit(long input)
        {
            var rankineTemp = input - 460L;
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
        public static long RankineToKelvin(long input)
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
        public static long RankineToGas(long input)
        {
            var celsiusTemp = RankineToCelsius(input);
            var gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }
    }
}
