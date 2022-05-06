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
    /// The to string extensions.
    /// </summary>
    public static class ToStringExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this CelsiusString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, CelsiusDoubleConversions.CelsiusToCelsius, fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this FahrenheitString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, FahrenheitDoubleConversions.FahrenheitToCelsius, fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this GasString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, GasDoubleConversion.GasToCelsius, fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this KelvinString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, KelvinDoubleConversions.KelvinToCelsius, fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this RankineString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, RankineDoubleConversions.RankineToCelsius, fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions string result.
        /// </returns>
        public static string ToFahrenheit(this CelsiusString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, CelsiusDoubleConversions.CelsiusToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions string result.
        /// </returns>
        public static string ToFahrenheit(this FahrenheitString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, FahrenheitDoubleConversions.FahrenheitToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions string result.
        /// </returns>
        public static string ToFahrenheit(this GasString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, GasDoubleConversion.GasToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions string result.
        /// </returns>
        public static string ToFahrenheit(this KelvinString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, KelvinDoubleConversions.KelvinToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions string result.
        /// </returns>
        public static string ToFahrenheit(this RankineString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, RankineDoubleConversions.RankineToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this CelsiusString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, CelsiusDoubleConversions.CelsiusToGas, fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this FahrenheitString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, FahrenheitDoubleConversions.FahrenheitToGas, fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this GasString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, GasDoubleConversion.GasToGas, fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this KelvinString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, KelvinDoubleConversions.KelvinToGas, fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this RankineString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, RankineDoubleConversions.RankineToGas, fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this CelsiusString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, CelsiusDoubleConversions.CelsiusToKelvin, fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this FahrenheitString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, FahrenheitDoubleConversions.FahrenheitToKelvin, fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this GasString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, GasDoubleConversion.GasToKelvin, fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this KelvinString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, KelvinDoubleConversions.KelvinToKelvin, fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this RankineString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, RankineDoubleConversions.RankineToKelvin, fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this CelsiusString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, CelsiusDoubleConversions.CelsiusToRankine, fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this FahrenheitString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, FahrenheitDoubleConversions.FahrenheitToRankine, fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this GasString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, GasDoubleConversion.GasToRankine, fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this KelvinString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, KelvinDoubleConversions.KelvinToRankine, fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this RankineString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, RankineDoubleConversions.RankineToRankine, fractionalCount);
        }

        /// <summary>
        /// Converts the String input to the correct string value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static string To<TInput>(this StringBase input, int fractionalCount = -1)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusDoubleConversions.CelsiusToCelsius, fractionalCount),
                nameof(Celsius) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitDoubleConversions.FahrenheitToCelsius, fractionalCount),
                nameof(Celsius) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinDoubleConversions.KelvinToCelsius, fractionalCount),
                nameof(Celsius) when input is GasString castInput => Parser(castInput.Temperature, GasDoubleConversion.GasToCelsius, fractionalCount),
                nameof(Celsius) when input is RankineString castInput => Parser(castInput.Temperature, RankineDoubleConversions.RankineToCelsius, fractionalCount),
                nameof(Fahrenheit) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusDoubleConversions.CelsiusToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitDoubleConversions.FahrenheitToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinDoubleConversions.KelvinToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is GasString castInput => Parser(castInput.Temperature, GasDoubleConversion.GasToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is RankineString castInput => Parser(castInput.Temperature, RankineDoubleConversions.RankineToFahrenheit, fractionalCount),
                nameof(Kelvin) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusDoubleConversions.CelsiusToKelvin, fractionalCount),
                nameof(Kelvin) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitDoubleConversions.FahrenheitToKelvin, fractionalCount),
                nameof(Kelvin) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinDoubleConversions.KelvinToKelvin, fractionalCount),
                nameof(Kelvin) when input is GasString castInput => Parser(castInput.Temperature, GasDoubleConversion.GasToKelvin, fractionalCount),
                nameof(Kelvin) when input is RankineString castInput => Parser(castInput.Temperature, RankineDoubleConversions.RankineToKelvin, fractionalCount),
                nameof(Gas) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusDoubleConversions.CelsiusToGas, fractionalCount),
                nameof(Gas) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitDoubleConversions.FahrenheitToGas, fractionalCount),
                nameof(Gas) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinDoubleConversions.KelvinToGas, fractionalCount),
                nameof(Gas) when input is GasString castInput => Parser(castInput.Temperature, GasDoubleConversion.GasToGas, fractionalCount),
                nameof(Gas) when input is RankineString castInput => Parser(castInput.Temperature, RankineDoubleConversions.RankineToGas, fractionalCount),
                nameof(Rankine) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusDoubleConversions.CelsiusToRankine, fractionalCount),
                nameof(Rankine) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitDoubleConversions.FahrenheitToRankine, fractionalCount),
                nameof(Rankine) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinDoubleConversions.KelvinToRankine, fractionalCount),
                nameof(Rankine) when input is GasString castInput => Parser(castInput.Temperature, GasDoubleConversion.GasToRankine, fractionalCount),
                nameof(Rankine) when input is RankineString castInput => Parser(castInput.Temperature, RankineDoubleConversions.RankineToRankine, fractionalCount),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static string Parser(string temp, Func<double, double> methodToParse, int fractionalCount)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(temp, out var inputAsDouble))
            {
                convertedTemp = Rounder(methodToParse(inputAsDouble), fractionalCount).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        private static double Rounder(double input, int fractionalCount = -1)
        {
            return fractionalCount < 0 ? input : Math.Round(input, fractionalCount);
        }
    }
}
