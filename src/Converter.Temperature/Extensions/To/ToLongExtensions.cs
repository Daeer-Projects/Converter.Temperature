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
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this FahrenheitLong input)
        {
            return LongParser(FahrenheitDoubleConversions.FahrenheitToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this GasLong input)
        {
            return LongParser(GasDoubleConversion.GasToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this KelvinLong input)
        {
            return LongParser(KelvinDoubleConversions.KelvinToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="long"/> result.
        /// </returns>
        public static long ToCelsius(this RankineLong input)
        {
            return LongParser(RankineDoubleConversions.RankineToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to CelsiusDoubleConversions
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
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this FahrenheitLong input)
        {
            return LongParser(FahrenheitDoubleConversions.FahrenheitToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this GasLong input)
        {
            return LongParser(GasDoubleConversion.GasToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this KelvinLong input)
        {
            return LongParser(KelvinDoubleConversions.KelvinToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="long"/> result.
        /// </returns>
        public static long ToFahrenheit(this RankineLong input)
        {
            return LongParser(RankineDoubleConversions.RankineToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this FahrenheitLong input)
        {
            return LongParser(FahrenheitDoubleConversions.FahrenheitToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this GasLong input)
        {
            return LongParser(GasDoubleConversion.GasToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this KelvinLong input)
        {
            return LongParser(KelvinDoubleConversions.KelvinToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="long"/> result.
        /// </returns>
        public static long ToGas(this RankineLong input)
        {
            return LongParser(RankineDoubleConversions.RankineToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this FahrenheitLong input)
        {
            return LongParser(FahrenheitDoubleConversions.FahrenheitToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The KelvinConverter <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this GasLong input)
        {
            return LongParser(GasDoubleConversion.GasToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this KelvinLong input)
        {
            return LongParser(KelvinDoubleConversions.KelvinToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter <see langword="long"/> result.
        /// </returns>
        public static long ToKelvin(this RankineLong input)
        {
            return LongParser(RankineDoubleConversions.RankineToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The RankineConverter <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this CelsiusLong input)
        {
            return CelsiusLongConversions.CelsiusToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The RankineConverter <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this FahrenheitLong input)
        {
            return LongParser(FahrenheitDoubleConversions.FahrenheitToRankine(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The RankineConverter <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this GasLong input)
        {
            return LongParser(GasDoubleConversion.GasToRankine(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this KelvinLong input)
        {
            return LongParser(KelvinDoubleConversions.KelvinToRankine(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="long"/> result.
        /// </returns>
        public static long ToRankine(this RankineLong input)
        {
            return LongParser(RankineDoubleConversions.RankineToRankine(input.Temperature));
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
                nameof(Celsius) when input is FahrenheitLong castInput => LongParser(FahrenheitDoubleConversions.FahrenheitToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is KelvinLong castInput => LongParser(KelvinDoubleConversions.KelvinToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is GasLong castInput => LongParser(GasDoubleConversion.GasToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is RankineLong castInput => LongParser(RankineDoubleConversions.RankineToCelsius(castInput.Temperature)),
                nameof(Fahrenheit) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is FahrenheitLong castInput => LongParser(FahrenheitDoubleConversions.FahrenheitToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is KelvinLong castInput => LongParser(KelvinDoubleConversions.KelvinToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is GasLong castInput => LongParser(GasDoubleConversion.GasToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is RankineLong castInput => LongParser(RankineDoubleConversions.RankineToFahrenheit(castInput.Temperature)),
                nameof(Kelvin) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is FahrenheitLong castInput => LongParser(FahrenheitDoubleConversions.FahrenheitToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is KelvinLong castInput => LongParser(KelvinDoubleConversions.KelvinToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is GasLong castInput => LongParser(GasDoubleConversion.GasToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is RankineLong castInput => LongParser(RankineDoubleConversions.RankineToKelvin(castInput.Temperature)),
                nameof(Gas) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToGas(castInput.Temperature),
                nameof(Gas) when input is FahrenheitLong castInput => LongParser(FahrenheitDoubleConversions.FahrenheitToGas(castInput.Temperature)),
                nameof(Gas) when input is KelvinLong castInput => LongParser(KelvinDoubleConversions.KelvinToGas(castInput.Temperature)),
                nameof(Gas) when input is GasLong castInput => LongParser(GasDoubleConversion.GasToGas(castInput.Temperature)),
                nameof(Gas) when input is RankineLong castInput => LongParser(RankineDoubleConversions.RankineToGas(castInput.Temperature)),
                nameof(Rankine) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToRankine(castInput.Temperature),
                nameof(Rankine) when input is FahrenheitLong castInput => LongParser(FahrenheitDoubleConversions.FahrenheitToRankine(castInput.Temperature)),
                nameof(Rankine) when input is KelvinLong castInput => LongParser(KelvinDoubleConversions.KelvinToRankine(castInput.Temperature)),
                nameof(Rankine) when input is GasLong castInput => LongParser(GasDoubleConversion.GasToRankine(castInput.Temperature)),
                nameof(Rankine) when input is RankineLong castInput => LongParser(RankineDoubleConversions.RankineToRankine(castInput.Temperature)),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static long LongParser(double temp)
        {
            temp = Math.Round(temp);
            if (!long.TryParse(temp.ToString(CultureInfo.InvariantCulture), out var convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return convertedTemp;
        }
    }
}
