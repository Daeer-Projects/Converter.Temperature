namespace Converter.Temperature.Extensions.To
{
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;

    /// <summary>
    /// The to <see langword="double"/> extensions.
    /// </summary>
    public static class ToDoubleExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this CelsiusDouble input)
        {
            return CelsiusConverter.CelsiusToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this FahrenheitDouble input)
        {
            return FahrenheitConverter.FahrenheitToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this GasDouble input)
        {
            return GasConverter.GasToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this KelvinDouble input)
        {
            return KelvinConverter.KelvinToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this RankineDouble input)
        {
            return RankineConverter.RankineToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this CelsiusDouble input)
        {
            return CelsiusConverter.CelsiusToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this FahrenheitDouble input)
        {
            return FahrenheitConverter.FahrenheitToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this GasDouble input)
        {
            return GasConverter.GasToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this KelvinDouble input)
        {
            return KelvinConverter.KelvinToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this RankineDouble input)
        {
            return RankineConverter.RankineToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this CelsiusDouble input)
        {
            return CelsiusConverter.CelsiusToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this FahrenheitDouble input)
        {
            return FahrenheitConverter.FahrenheitToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this GasDouble input)
        {
            return GasConverter.GasToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this KelvinDouble input)
        {
            return KelvinConverter.KelvinToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this RankineDouble input)
        {
            return RankineConverter.RankineToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this CelsiusDouble input)
        {
            return CelsiusConverter.CelsiusToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this FahrenheitDouble input)
        {
            return FahrenheitConverter.FahrenheitToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this GasDouble input)
        {
            return GasConverter.GasToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this KelvinDouble input)
        {
            return KelvinConverter.KelvinToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this RankineDouble input)
        {
            return RankineConverter.RankineToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this CelsiusDouble input)
        {
            return CelsiusConverter.CelsiusToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this FahrenheitDouble input)
        {
            return FahrenheitConverter.FahrenheitToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this GasDouble input)
        {
            return GasConverter.GasToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this KelvinDouble input)
        {
            return KelvinConverter.KelvinToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this RankineDouble input)
        {
            return RankineConverter.RankineToRankine(input.Temperature);
        }
    }
}