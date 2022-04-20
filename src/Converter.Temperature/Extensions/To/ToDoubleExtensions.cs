namespace Converter.Temperature.Extensions.To
{
    using System;
    using BaseTypes;
    using TemperatureTypes;
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
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this CelsiusDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(CelsiusConverter.CelsiusToCelsius(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this FahrenheitDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(FahrenheitConverter.FahrenheitToCelsius(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this GasDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(GasConverter.GasToCelsius(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this KelvinDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(KelvinConverter.KelvinToCelsius(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this RankineDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(RankineConverter.RankineToCelsius(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this CelsiusDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(CelsiusConverter.CelsiusToFahrenheit(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this FahrenheitDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(FahrenheitConverter.FahrenheitToFahrenheit(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this GasDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(GasConverter.GasToFahrenheit(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this KelvinDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(KelvinConverter.KelvinToFahrenheit(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this RankineDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(RankineConverter.RankineToFahrenheit(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this CelsiusDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(CelsiusConverter.CelsiusToGas(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this FahrenheitDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(FahrenheitConverter.FahrenheitToGas(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this GasDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(GasConverter.GasToGas(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this KelvinDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(KelvinConverter.KelvinToGas(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this RankineDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(RankineConverter.RankineToGas(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this CelsiusDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(CelsiusConverter.CelsiusToKelvin(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this FahrenheitDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(FahrenheitConverter.FahrenheitToKelvin(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this GasDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(GasConverter.GasToKelvin(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this KelvinDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(KelvinConverter.KelvinToKelvin(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this RankineDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(RankineConverter.RankineToKelvin(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this CelsiusDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(CelsiusConverter.CelsiusToRankine(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this FahrenheitDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(FahrenheitConverter.FahrenheitToRankine(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this GasDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(GasConverter.GasToRankine(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this KelvinDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(KelvinConverter.KelvinToRankine(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Ranking
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The RankineConverter <see langword="double"/> result.
        /// </returns>
        public static double ToRankine(this RankineDouble input, int fractionalCount = -1)
        {
            return DoubleRounder(RankineConverter.RankineToRankine(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Double input to the correct double value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static double To<TInput>(this DoubleBase input, int fractionalCount = -1)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusDouble castInput => DoubleRounder(CelsiusConverter.CelsiusToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is FahrenheitDouble castInput => DoubleRounder(FahrenheitConverter.FahrenheitToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is KelvinDouble castInput => DoubleRounder(KelvinConverter.KelvinToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is GasDouble castInput => DoubleRounder(GasConverter.GasToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is RankineDouble castInput => DoubleRounder(RankineConverter.RankineToCelsius(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is CelsiusDouble castInput => DoubleRounder(CelsiusConverter.CelsiusToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is FahrenheitDouble castInput => DoubleRounder(FahrenheitConverter.FahrenheitToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is KelvinDouble castInput => DoubleRounder(KelvinConverter.KelvinToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is GasDouble castInput => DoubleRounder(GasConverter.GasToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is RankineDouble castInput => DoubleRounder(RankineConverter.RankineToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is CelsiusDouble castInput => DoubleRounder(CelsiusConverter.CelsiusToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is FahrenheitDouble castInput => DoubleRounder(FahrenheitConverter.FahrenheitToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is KelvinDouble castInput => DoubleRounder(KelvinConverter.KelvinToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is GasDouble castInput => DoubleRounder(GasConverter.GasToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is RankineDouble castInput => DoubleRounder(RankineConverter.RankineToKelvin(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is CelsiusDouble castInput => DoubleRounder(CelsiusConverter.CelsiusToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is FahrenheitDouble castInput => DoubleRounder(FahrenheitConverter.FahrenheitToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is KelvinDouble castInput => DoubleRounder(KelvinConverter.KelvinToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is GasDouble castInput => DoubleRounder(GasConverter.GasToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is RankineDouble castInput => DoubleRounder(RankineConverter.RankineToGas(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is CelsiusDouble castInput => DoubleRounder(CelsiusConverter.CelsiusToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is FahrenheitDouble castInput => DoubleRounder(FahrenheitConverter.FahrenheitToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is KelvinDouble castInput => DoubleRounder(KelvinConverter.KelvinToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is GasDouble castInput => DoubleRounder(GasConverter.GasToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is RankineDouble castInput => DoubleRounder(RankineConverter.RankineToRankine(castInput.Temperature), fractionalCount),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static double DoubleRounder(double input, int fractionalCount = -1)
        {
            if (fractionalCount < 0)
                return input;

            return Math.Round(input, fractionalCount);
        }
    }
}