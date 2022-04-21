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
            return Rounder(CelsiusConverter.CelsiusToCelsius(input.Temperature), fractionalCount);
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
            return Rounder(FahrenheitConverter.FahrenheitToCelsius(input.Temperature), fractionalCount);
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
            return Rounder(GasConverter.GasToCelsius(input.Temperature), fractionalCount);
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
            return Rounder(KelvinConverter.KelvinToCelsius(input.Temperature), fractionalCount);
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
            return Rounder(RankineConverter.RankineToCelsius(input.Temperature), fractionalCount);
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
            return Rounder(CelsiusConverter.CelsiusToFahrenheit(input.Temperature), fractionalCount);
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
            return Rounder(FahrenheitConverter.FahrenheitToFahrenheit(input.Temperature), fractionalCount);
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
            return Rounder(GasConverter.GasToFahrenheit(input.Temperature), fractionalCount);
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
            return Rounder(KelvinConverter.KelvinToFahrenheit(input.Temperature), fractionalCount);
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
            return Rounder(RankineConverter.RankineToFahrenheit(input.Temperature), fractionalCount);
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
            return Rounder(CelsiusConverter.CelsiusToGas(input.Temperature), fractionalCount);
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
            return Rounder(FahrenheitConverter.FahrenheitToGas(input.Temperature), fractionalCount);
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
            return Rounder(GasConverter.GasToGas(input.Temperature), fractionalCount);
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
            return Rounder(KelvinConverter.KelvinToGas(input.Temperature), fractionalCount);
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
            return Rounder(RankineConverter.RankineToGas(input.Temperature), fractionalCount);
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
            return Rounder(CelsiusConverter.CelsiusToKelvin(input.Temperature), fractionalCount);
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
            return Rounder(FahrenheitConverter.FahrenheitToKelvin(input.Temperature), fractionalCount);
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
            return Rounder(GasConverter.GasToKelvin(input.Temperature), fractionalCount);
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
            return Rounder(KelvinConverter.KelvinToKelvin(input.Temperature), fractionalCount);
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
            return Rounder(RankineConverter.RankineToKelvin(input.Temperature), fractionalCount);
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
            return Rounder(CelsiusConverter.CelsiusToRankine(input.Temperature), fractionalCount);
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
            return Rounder(FahrenheitConverter.FahrenheitToRankine(input.Temperature), fractionalCount);
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
            return Rounder(GasConverter.GasToRankine(input.Temperature), fractionalCount);
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
            return Rounder(KelvinConverter.KelvinToRankine(input.Temperature), fractionalCount);
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
            return Rounder(RankineConverter.RankineToRankine(input.Temperature), fractionalCount);
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
                nameof(Celsius) when input is CelsiusDouble castInput => Rounder(CelsiusConverter.CelsiusToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is FahrenheitDouble castInput => Rounder(FahrenheitConverter.FahrenheitToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is KelvinDouble castInput => Rounder(KelvinConverter.KelvinToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is GasDouble castInput => Rounder(GasConverter.GasToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is RankineDouble castInput => Rounder(RankineConverter.RankineToCelsius(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is CelsiusDouble castInput => Rounder(CelsiusConverter.CelsiusToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is FahrenheitDouble castInput => Rounder(FahrenheitConverter.FahrenheitToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is KelvinDouble castInput => Rounder(KelvinConverter.KelvinToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is GasDouble castInput => Rounder(GasConverter.GasToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is RankineDouble castInput => Rounder(RankineConverter.RankineToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is CelsiusDouble castInput => Rounder(CelsiusConverter.CelsiusToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is FahrenheitDouble castInput => Rounder(FahrenheitConverter.FahrenheitToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is KelvinDouble castInput => Rounder(KelvinConverter.KelvinToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is GasDouble castInput => Rounder(GasConverter.GasToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is RankineDouble castInput => Rounder(RankineConverter.RankineToKelvin(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is CelsiusDouble castInput => Rounder(CelsiusConverter.CelsiusToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is FahrenheitDouble castInput => Rounder(FahrenheitConverter.FahrenheitToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is KelvinDouble castInput => Rounder(KelvinConverter.KelvinToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is GasDouble castInput => Rounder(GasConverter.GasToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is RankineDouble castInput => Rounder(RankineConverter.RankineToGas(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is CelsiusDouble castInput => Rounder(CelsiusConverter.CelsiusToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is FahrenheitDouble castInput => Rounder(FahrenheitConverter.FahrenheitToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is KelvinDouble castInput => Rounder(KelvinConverter.KelvinToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is GasDouble castInput => Rounder(GasConverter.GasToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is RankineDouble castInput => Rounder(RankineConverter.RankineToRankine(castInput.Temperature), fractionalCount),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static double Rounder(double input, int fractionalCount = -1)
        {
            return fractionalCount < 0 ? input : Math.Round(input, fractionalCount);
        }
    }
}