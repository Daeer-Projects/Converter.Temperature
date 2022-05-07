namespace Converter.Temperature.Converters.Rankine
{
    using Celsius;

    internal static class RankineIntConversions
    {
        /// <summary>
        /// The rankine to rankine conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int RankineToRankine(int input)
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
        public static int RankineToCelsius(int input)
        {
            var rankineTemp = (input - 492) * 5 / 9;
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
        public static int RankineToFahrenheit(int input)
        {
            var rankineTemp = input - 460;
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
        public static int RankineToKelvin(int input)
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
        public static int RankineToGas(int input)
        {
            var celsiusTemp = RankineToCelsius(input);
            var gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }
    }
}
