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
            return LongParser(CelsiusDoubleConversions.CelsiusToCelsius(input.Temperature));
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
            return LongParser(DoubleFahrenheitConversions.FahrenheitToCelsius(input.Temperature));
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
            return LongParser(GasConverter.GasToCelsius(input.Temperature));
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
            return LongParser(KelvinConverter.KelvinToCelsius(input.Temperature));
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
            return LongParser(RankineConverter.RankineToCelsius(input.Temperature));
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
            return LongParser(CelsiusDoubleConversions.CelsiusToFahrenheit(input.Temperature));
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
            return LongParser(DoubleFahrenheitConversions.FahrenheitToFahrenheit(input.Temperature));
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
            return LongParser(GasConverter.GasToFahrenheit(input.Temperature));
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
            return LongParser(KelvinConverter.KelvinToFahrenheit(input.Temperature));
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
            return LongParser(RankineConverter.RankineToFahrenheit(input.Temperature));
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
            return LongParser(CelsiusDoubleConversions.CelsiusToGas(input.Temperature));
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
            return LongParser(DoubleFahrenheitConversions.FahrenheitToGas(input.Temperature));
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
            return LongParser(GasConverter.GasToGas(input.Temperature));
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
            return LongParser(KelvinConverter.KelvinToGas(input.Temperature));
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
            return LongParser(RankineConverter.RankineToGas(input.Temperature));
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
            return LongParser(CelsiusDoubleConversions.CelsiusToKelvin(input.Temperature));
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
            return LongParser(DoubleFahrenheitConversions.FahrenheitToKelvin(input.Temperature));
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
            return LongParser(GasConverter.GasToKelvin(input.Temperature));
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
            return LongParser(KelvinConverter.KelvinToKelvin(input.Temperature));
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
            return LongParser(RankineConverter.RankineToKelvin(input.Temperature));
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
            return LongParser(CelsiusDoubleConversions.CelsiusToRankine(input.Temperature));
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
            return LongParser(DoubleFahrenheitConversions.FahrenheitToRankine(input.Temperature));
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
            return LongParser(GasConverter.GasToRankine(input.Temperature));
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
            return LongParser(KelvinConverter.KelvinToRankine(input.Temperature));
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
            return LongParser(RankineConverter.RankineToRankine(input.Temperature));
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
                nameof(Celsius) when input is CelsiusLong castInput => LongParser(CelsiusDoubleConversions.CelsiusToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is FahrenheitLong castInput => LongParser(DoubleFahrenheitConversions.FahrenheitToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is KelvinLong castInput => LongParser(KelvinConverter.KelvinToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is GasLong castInput => LongParser(GasConverter.GasToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is RankineLong castInput => LongParser(RankineConverter.RankineToCelsius(castInput.Temperature)),
                nameof(Fahrenheit) when input is CelsiusLong castInput => LongParser(CelsiusDoubleConversions.CelsiusToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is FahrenheitLong castInput => LongParser(DoubleFahrenheitConversions.FahrenheitToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is KelvinLong castInput => LongParser(KelvinConverter.KelvinToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is GasLong castInput => LongParser(GasConverter.GasToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is RankineLong castInput => LongParser(RankineConverter.RankineToFahrenheit(castInput.Temperature)),
                nameof(Kelvin) when input is CelsiusLong castInput => LongParser(CelsiusDoubleConversions.CelsiusToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is FahrenheitLong castInput => LongParser(DoubleFahrenheitConversions.FahrenheitToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is KelvinLong castInput => LongParser(KelvinConverter.KelvinToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is GasLong castInput => LongParser(GasConverter.GasToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is RankineLong castInput => LongParser(RankineConverter.RankineToKelvin(castInput.Temperature)),
                nameof(Gas) when input is CelsiusLong castInput => LongParser(CelsiusDoubleConversions.CelsiusToGas(castInput.Temperature)),
                nameof(Gas) when input is FahrenheitLong castInput => LongParser(DoubleFahrenheitConversions.FahrenheitToGas(castInput.Temperature)),
                nameof(Gas) when input is KelvinLong castInput => LongParser(KelvinConverter.KelvinToGas(castInput.Temperature)),
                nameof(Gas) when input is GasLong castInput => LongParser(GasConverter.GasToGas(castInput.Temperature)),
                nameof(Gas) when input is RankineLong castInput => LongParser(RankineConverter.RankineToGas(castInput.Temperature)),
                nameof(Rankine) when input is CelsiusLong castInput => LongParser(CelsiusDoubleConversions.CelsiusToRankine(castInput.Temperature)),
                nameof(Rankine) when input is FahrenheitLong castInput => LongParser(DoubleFahrenheitConversions.FahrenheitToRankine(castInput.Temperature)),
                nameof(Rankine) when input is KelvinLong castInput => LongParser(KelvinConverter.KelvinToRankine(castInput.Temperature)),
                nameof(Rankine) when input is GasLong castInput => LongParser(GasConverter.GasToRankine(castInput.Temperature)),
                nameof(Rankine) when input is RankineLong castInput => LongParser(RankineConverter.RankineToRankine(castInput.Temperature)),
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
