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

        /// <summary>
        /// Converts the Double input to the correct double value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static double To<TInput>(this DoubleBase input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusDouble castInput => CelsiusConverter.CelsiusToCelsius(castInput.Temperature),
                nameof(Celsius) when input is FahrenheitDouble castInput => FahrenheitConverter.FahrenheitToCelsius(castInput.Temperature),
                nameof(Celsius) when input is KelvinDouble castInput => KelvinConverter.KelvinToCelsius(castInput.Temperature),
                nameof(Celsius) when input is GasDouble castInput => GasConverter.GasToCelsius(castInput.Temperature),
                nameof(Celsius) when input is RankineDouble castInput => RankineConverter.RankineToCelsius(castInput.Temperature),
                nameof(Fahrenheit) when input is CelsiusDouble castInput => CelsiusConverter.CelsiusToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is FahrenheitDouble castInput => FahrenheitConverter.FahrenheitToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is KelvinDouble castInput => KelvinConverter.KelvinToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is GasDouble castInput => GasConverter.GasToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is RankineDouble castInput => RankineConverter.RankineToFahrenheit(castInput.Temperature),
                nameof(Kelvin) when input is CelsiusDouble castInput => CelsiusConverter.CelsiusToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is FahrenheitDouble castInput => FahrenheitConverter.FahrenheitToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is KelvinDouble castInput => KelvinConverter.KelvinToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is GasDouble castInput => GasConverter.GasToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is RankineDouble castInput => RankineConverter.RankineToKelvin(castInput.Temperature),
                nameof(Gas) when input is CelsiusDouble castInput => CelsiusConverter.CelsiusToGas(castInput.Temperature),
                nameof(Gas) when input is FahrenheitDouble castInput => FahrenheitConverter.FahrenheitToGas(castInput.Temperature),
                nameof(Gas) when input is KelvinDouble castInput => KelvinConverter.KelvinToGas(castInput.Temperature),
                nameof(Gas) when input is GasDouble castInput => GasConverter.GasToGas(castInput.Temperature),
                nameof(Gas) when input is RankineDouble castInput => RankineConverter.RankineToGas(castInput.Temperature),
                nameof(Rankine) when input is CelsiusDouble castInput => CelsiusConverter.CelsiusToRankine(castInput.Temperature),
                nameof(Rankine) when input is FahrenheitDouble castInput => FahrenheitConverter.FahrenheitToRankine(castInput.Temperature),
                nameof(Rankine) when input is KelvinDouble castInput => KelvinConverter.KelvinToRankine(castInput.Temperature),
                nameof(Rankine) when input is GasDouble castInput => GasConverter.GasToRankine(castInput.Temperature),
                nameof(Rankine) when input is RankineDouble castInput => RankineConverter.RankineToRankine(castInput.Temperature),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}