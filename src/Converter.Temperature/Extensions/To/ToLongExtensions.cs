namespace Converter.Temperature.Extensions.To
{
    using System;
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

    public static class ToLongExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this FahrenheitLong input)
        {
            return FahrenheitLongConversions.FahrenheitToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this GasLong input)
        {
            return GasLongConversions.GasToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this KelvinLong input)
        {
            return KelvinLongConversions.KelvinToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this RankineLong input)
        {
            return RankineLongConversions.RankineToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Fahrenheit <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this FahrenheitLong input)
        {
            return FahrenheitLongConversions.FahrenheitToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Fahrenheit <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this GasLong input)
        {
            return GasLongConversions.GasToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Fahrenheit <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this KelvinLong input)
        {
            return KelvinLongConversions.KelvinToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Fahrenheit <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this RankineLong input)
        {
            return RankineLongConversions.RankineToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this FahrenheitLong input)
        {
            return FahrenheitLongConversions.FahrenheitToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this GasLong input)
        {
            return GasLongConversions.GasToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this KelvinLong input)
        {
            return KelvinLongConversions.KelvinToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Gas <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this RankineLong input)
        {
            return RankineLongConversions.RankineToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Kelvin <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Kelvin <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this FahrenheitLong input)
        {
            return FahrenheitLongConversions.FahrenheitToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Kelvin <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this GasLong input)
        {
            return GasLongConversions.GasToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this KelvinLong input)
        {
            return KelvinLongConversions.KelvinToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this RankineLong input)
        {
            return RankineLongConversions.RankineToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Rankine <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Rankine <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this FahrenheitLong input)
        {
            return FahrenheitLongConversions.FahrenheitToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Rankine <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this GasLong input)
        {
            return GasLongConversions.GasToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this KelvinLong input)
        {
            return KelvinLongConversions.KelvinToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this RankineLong input)
        {
            return RankineLongConversions.RankineToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the Long input to the correct Long value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static long To<TInput>(this LongBase input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToCelsius(castInput.Temperature),
                nameof(Celsius) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToCelsius(castInput.Temperature),
                nameof(Celsius) when input is KelvinLong castInput => KelvinLongConversions.KelvinToCelsius(castInput.Temperature),
                nameof(Celsius) when input is GasLong castInput => GasLongConversions.GasToCelsius(castInput.Temperature),
                nameof(Celsius) when input is RankineLong castInput => RankineLongConversions.RankineToCelsius(castInput.Temperature),
                nameof(Fahrenheit) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is KelvinLong castInput => KelvinLongConversions.KelvinToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is GasLong castInput => GasLongConversions.GasToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is RankineLong castInput => RankineLongConversions.RankineToFahrenheit(castInput.Temperature),
                nameof(Kelvin) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is KelvinLong castInput => KelvinLongConversions.KelvinToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is GasLong castInput => GasLongConversions.GasToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is RankineLong castInput => RankineLongConversions.RankineToKelvin(castInput.Temperature),
                nameof(Gas) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToGas(castInput.Temperature),
                nameof(Gas) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToGas(castInput.Temperature),
                nameof(Gas) when input is KelvinLong castInput => KelvinLongConversions.KelvinToGas(castInput.Temperature),
                nameof(Gas) when input is GasLong castInput => GasLongConversions.GasToGas(castInput.Temperature),
                nameof(Gas) when input is RankineLong castInput => RankineLongConversions.RankineToGas(castInput.Temperature),
                nameof(Rankine) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToRankine(castInput.Temperature),
                nameof(Rankine) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToRankine(castInput.Temperature),
                nameof(Rankine) when input is KelvinLong castInput => KelvinLongConversions.KelvinToRankine(castInput.Temperature),
                nameof(Rankine) when input is GasLong castInput => GasLongConversions.GasToRankine(castInput.Temperature),
                nameof(Rankine) when input is RankineLong castInput => RankineLongConversions.RankineToRankine(castInput.Temperature),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}
