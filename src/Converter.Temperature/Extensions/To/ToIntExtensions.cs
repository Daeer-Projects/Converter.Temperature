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
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this FahrenheitInt input)
        {
            return IntParser(FahrenheitDoubleConversions.FahrenheitToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this GasInt input)
        {
            return IntParser(GasDoubleConversion.GasToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this KelvinInt input)
        {
            return IntParser(KelvinDoubleConversions.KelvinToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this RankineInt input)
        {
            return IntParser(RankineDoubleConversions.RankineToCelsius(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this FahrenheitInt input)
        {
            return IntParser(FahrenheitDoubleConversions.FahrenheitToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this GasInt input)
        {
            return IntParser(GasDoubleConversion.GasToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this KelvinInt input)
        {
            return IntParser(KelvinDoubleConversions.KelvinToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this RankineInt input)
        {
            return IntParser(RankineDoubleConversions.RankineToFahrenheit(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this FahrenheitInt input)
        {
            return IntParser(FahrenheitDoubleConversions.FahrenheitToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this GasInt input)
        {
            return IntParser(GasDoubleConversion.GasToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this KelvinInt input)
        {
            return IntParser(KelvinDoubleConversions.KelvinToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this RankineInt input)
        {
            return IntParser(RankineDoubleConversions.RankineToGas(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this FahrenheitInt input)
        {
            return IntParser(FahrenheitDoubleConversions.FahrenheitToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this GasInt input)
        {
            return IntParser(GasDoubleConversion.GasToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this KelvinInt input)
        {
            return IntParser(KelvinDoubleConversions.KelvinToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this RankineInt input)
        {
            return IntParser(RankineDoubleConversions.RankineToKelvin(input.Temperature));
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this CelsiusInt input)
        {
            return CelsiusIntConversions.CelsiusToRankine(input.Temperature);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this FahrenheitInt input)
        {
            return IntParser(FahrenheitDoubleConversions.FahrenheitToRankine(input.Temperature));
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this GasInt input)
        {
            return IntParser(GasDoubleConversion.GasToRankine(input.Temperature));
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this KelvinInt input)
        {
            return IntParser(KelvinDoubleConversions.KelvinToRankine(input.Temperature));
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this RankineInt input)
        {
            return IntParser(RankineDoubleConversions.RankineToRankine(input.Temperature));
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
                nameof(Celsius) when input is FahrenheitInt castInput => IntParser(FahrenheitDoubleConversions.FahrenheitToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is KelvinInt castInput => IntParser(KelvinDoubleConversions.KelvinToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is GasInt castInput =>  IntParser(GasDoubleConversion.GasToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is RankineInt castInput => IntParser(RankineDoubleConversions.RankineToCelsius(castInput.Temperature)),
                nameof(Fahrenheit) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToFahrenheit(castInput.Temperature),
                nameof(Fahrenheit) when input is FahrenheitInt castInput => IntParser(FahrenheitDoubleConversions.FahrenheitToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is KelvinInt castInput => IntParser(KelvinDoubleConversions.KelvinToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is GasInt castInput => IntParser(GasDoubleConversion.GasToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is RankineInt castInput => IntParser(RankineDoubleConversions.RankineToFahrenheit(castInput.Temperature)),
                nameof(Kelvin) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToKelvin(castInput.Temperature),
                nameof(Kelvin) when input is FahrenheitInt castInput => IntParser(FahrenheitDoubleConversions.FahrenheitToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is KelvinInt castInput => IntParser(KelvinDoubleConversions.KelvinToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is GasInt castInput => IntParser(GasDoubleConversion.GasToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is RankineInt castInput => IntParser(RankineDoubleConversions.RankineToKelvin(castInput.Temperature)),
                nameof(Gas) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToGas(castInput.Temperature),
                nameof(Gas) when input is FahrenheitInt castInput => IntParser(FahrenheitDoubleConversions.FahrenheitToGas(castInput.Temperature)),
                nameof(Gas) when input is KelvinInt castInput => IntParser(KelvinDoubleConversions.KelvinToGas(castInput.Temperature)),
                nameof(Gas) when input is GasInt castInput => IntParser(GasDoubleConversion.GasToGas(castInput.Temperature)),
                nameof(Gas) when input is RankineInt castInput => IntParser(RankineDoubleConversions.RankineToGas(castInput.Temperature)),
                nameof(Rankine) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToRankine(castInput.Temperature),
                nameof(Rankine) when input is FahrenheitInt castInput => IntParser(FahrenheitDoubleConversions.FahrenheitToRankine(castInput.Temperature)),
                nameof(Rankine) when input is KelvinInt castInput => IntParser(KelvinDoubleConversions.KelvinToRankine(castInput.Temperature)),
                nameof(Rankine) when input is GasInt castInput => IntParser(GasDoubleConversion.GasToRankine(castInput.Temperature)),
                nameof(Rankine) when input is RankineInt castInput => IntParser(RankineDoubleConversions.RankineToRankine(castInput.Temperature)),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static int IntParser(double temp)
        {
            temp = Math.Round(temp);
            if (!int.TryParse(temp.ToString(CultureInfo.InvariantCulture), out var convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return convertedTemp;
        }
    }
}