namespace Converter.Temperature.Extensions.To
{
    using System.Globalization;
    using Converter.Temperature.Types.Celsius;
    using Converter.Temperature.Types.Fahrenheit;
    using Converter.Temperature.Types.Gas;
    using Converter.Temperature.Types.Kelvin;
    using Types.Rankine;

    /// <summary>
    /// The to string extensions.
    /// </summary>
    public static class ToStringExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this RankineString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this RankineString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this RankineString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this RankineString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this RankineString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }
    }
}
