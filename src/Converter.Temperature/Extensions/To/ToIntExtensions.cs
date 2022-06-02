namespace Converter.Temperature.Extensions.To
{
    using System;
    using System.Globalization;
    using BaseTypes;
    using Converters.Celsius;
    using Converters.Fahrenheit;
    using Converters.Gas;
    using Converters.Kelvin;
    using Converters.Rankine;
    using TemperatureTypes;
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;

    /// <summary>
    /// The to <see langword="int"/> extensions.
    /// </summary>
    public static class ToIntExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this FahrenheitInt input)
        {
            return FahrenheitIntConversions.FahrenheitToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this GasInt input)
        {
            return GasIntConversions.GasToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this KelvinInt input)
        {
            return KelvinIntConversions.KelvinToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this RankineInt input)
        {
            return RankineIntConversions.RankineToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this FahrenheitInt input)
        {
            return FahrenheitIntConversions.FahrenheitToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this GasInt input)
        {
            return GasIntConversions.GasToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this KelvinInt input)
        {
            return KelvinIntConversions.KelvinToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this RankineInt input)
        {
            return RankineIntConversions.RankineToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this FahrenheitInt input)
        {
            return FahrenheitIntConversions.FahrenheitToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this GasInt input)
        {
            return GasIntConversions.GasToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this KelvinInt input)
        {
            return KelvinIntConversions.KelvinToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this RankineInt input)
        {
            return RankineIntConversions.RankineToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this FahrenheitInt input)
        {
            return FahrenheitIntConversions.FahrenheitToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this GasInt input)
        {
            return GasIntConversions.GasToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this KelvinInt input)
        {
            return KelvinIntConversions.KelvinToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this RankineInt input)
        {
            return RankineIntConversions.RankineToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this FahrenheitInt input)
        {
            return FahrenheitIntConversions.FahrenheitToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this GasInt input)
        {
            return GasIntConversions.GasToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this KelvinInt input)
        {
            return KelvinIntConversions.KelvinToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this RankineInt input)
        {
            return RankineIntConversions.RankineToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Int input to the correct int value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static int To<TInput>(this IntBase input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToCelsius(castInput.Temperature),
                nameof(Celsius) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToCelsius(castInput.Temperature),
                nameof(Celsius) when input is KelvinInt castInput => KelvinIntConversions.KelvinToCelsius(castInput.Temperature),
                nameof(Celsius) when input is GasInt castInput =>  GasIntConversions.GasToCelsius(castInput.Temperature),
                nameof(Celsius) when input is RankineInt castInput => RankineIntConversions.RankineToCelsius(castInput.Temperature),
                nameof(Fahrenheit) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is KelvinInt castInput => KelvinIntConversions.KelvinToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is GasInt castInput => GasIntConversions.GasToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is RankineInt castInput => RankineIntConversions.RankineToFahrenheit(castInput.Temperature),
                nameof(Kelvin) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is KelvinInt castInput => KelvinIntConversions.KelvinToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is GasInt castInput => GasIntConversions.GasToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is RankineInt castInput => RankineIntConversions.RankineToKelvin(castInput.Temperature),
                nameof(Gas) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToGas(castInput.Temperature),
                nameof(Gas) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToGas(castInput.Temperature),
                nameof(Gas) when input is KelvinInt castInput => KelvinIntConversions.KelvinToGas(castInput.Temperature),
                nameof(Gas) when input is GasInt castInput => GasIntConversions.GasToGas(castInput.Temperature),
                nameof(Gas) when input is RankineInt castInput => RankineIntConversions.RankineToGas(castInput.Temperature),
                nameof(Rankine) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToRankine(castInput.Temperature),
                nameof(Rankine) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToRankine(castInput.Temperature),
                nameof(Rankine) when input is KelvinInt castInput => KelvinIntConversions.KelvinToRankine(castInput.Temperature),
                nameof(Rankine) when input is GasInt castInput => GasIntConversions.GasToRankine(castInput.Temperature),
                nameof(Rankine) when input is RankineInt castInput => RankineIntConversions.RankineToRankine(castInput.Temperature),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}