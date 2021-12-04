namespace Converter.Temperature
{
    internal static class RankineConverter
    {
        /// <summary>
        /// The rankine to rankine conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double RankineToRankine(double input)
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
        public static double RankineToCelsius(double input)
        {
            var rankineTemp = (input - 491.67) * 5 / 9;
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
        public static double RankineToFahrenheit(double input)
        {
            var rankineTemp = input - 459.67;
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
        public static double RankineToKelvin(double input)
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
        public static double RankineToGas(double input)
        {
            var celsiusTemp = RankineToCelsius(input);
            var gasTemp = CelsiusConverter.CelsiusToGas(celsiusTemp);
            return gasTemp;
        }
    }
}
