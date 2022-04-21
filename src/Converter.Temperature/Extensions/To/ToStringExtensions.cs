namespace Converter.Temperature.Extensions.To
{
    using System;
    using System.Globalization;
    using BaseTypes;
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
            return Parser(input.Temperature, CelsiusConverter.CelsiusToCelsius, fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this FahrenheitString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, FahrenheitConverter.FahrenheitToCelsius, fractionalCount);
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
            return Parser(input.Temperature, GasConverter.GasToCelsius, fractionalCount);
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
            return Parser(input.Temperature, KelvinConverter.KelvinToCelsius, fractionalCount);
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
            return Parser(input.Temperature, RankineConverter.RankineToCelsius, fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this CelsiusString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, CelsiusConverter.CelsiusToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this FahrenheitString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, FahrenheitConverter.FahrenheitToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this GasString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, GasConverter.GasToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this KelvinString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, KelvinConverter.KelvinToFahrenheit, fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this RankineString input, int fractionalCount = -1)
        {
            return Parser(input.Temperature, RankineConverter.RankineToFahrenheit, fractionalCount);
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
            return Parser(input.Temperature, CelsiusConverter.CelsiusToGas, fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to GasConverter
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
            return Parser(input.Temperature, FahrenheitConverter.FahrenheitToGas, fractionalCount);
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
            return Parser(input.Temperature, GasConverter.GasToGas, fractionalCount);
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
            return Parser(input.Temperature, KelvinConverter.KelvinToGas, fractionalCount);
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
            return Parser(input.Temperature, RankineConverter.RankineToGas, fractionalCount);
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
            return Parser(input.Temperature, CelsiusConverter.CelsiusToKelvin, fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
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
            return Parser(input.Temperature, FahrenheitConverter.FahrenheitToKelvin, fractionalCount);
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
            return Parser(input.Temperature, GasConverter.GasToKelvin, fractionalCount);
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
            return Parser(input.Temperature, KelvinConverter.KelvinToKelvin, fractionalCount);
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
            return Parser(input.Temperature, RankineConverter.RankineToKelvin, fractionalCount);
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
            return Parser(input.Temperature, CelsiusConverter.CelsiusToRankine, fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to RankineConverter
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
            return Parser(input.Temperature, FahrenheitConverter.FahrenheitToRankine, fractionalCount);
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
            return Parser(input.Temperature, GasConverter.GasToRankine, fractionalCount);
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
            return Parser(input.Temperature, KelvinConverter.KelvinToRankine, fractionalCount);
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
            return Parser(input.Temperature, RankineConverter.RankineToRankine, fractionalCount);
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
                nameof(Celsius) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusConverter.CelsiusToCelsius, fractionalCount),
                nameof(Celsius) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitConverter.FahrenheitToCelsius, fractionalCount),
                nameof(Celsius) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinConverter.KelvinToCelsius, fractionalCount),
                nameof(Celsius) when input is GasString castInput => Parser(castInput.Temperature, GasConverter.GasToCelsius, fractionalCount),
                nameof(Celsius) when input is RankineString castInput => Parser(castInput.Temperature, RankineConverter.RankineToCelsius, fractionalCount),
                nameof(Fahrenheit) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusConverter.CelsiusToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitConverter.FahrenheitToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinConverter.KelvinToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is GasString castInput => Parser(castInput.Temperature, GasConverter.GasToFahrenheit, fractionalCount),
                nameof(Fahrenheit) when input is RankineString castInput => Parser(castInput.Temperature, RankineConverter.RankineToFahrenheit, fractionalCount),
                nameof(Kelvin) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusConverter.CelsiusToKelvin, fractionalCount),
                nameof(Kelvin) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitConverter.FahrenheitToKelvin, fractionalCount),
                nameof(Kelvin) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinConverter.KelvinToKelvin, fractionalCount),
                nameof(Kelvin) when input is GasString castInput => Parser(castInput.Temperature, GasConverter.GasToKelvin, fractionalCount),
                nameof(Kelvin) when input is RankineString castInput => Parser(castInput.Temperature, RankineConverter.RankineToKelvin, fractionalCount),
                nameof(Gas) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusConverter.CelsiusToGas, fractionalCount),
                nameof(Gas) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitConverter.FahrenheitToGas, fractionalCount),
                nameof(Gas) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinConverter.KelvinToGas, fractionalCount),
                nameof(Gas) when input is GasString castInput => Parser(castInput.Temperature, GasConverter.GasToGas, fractionalCount),
                nameof(Gas) when input is RankineString castInput => Parser(castInput.Temperature, RankineConverter.RankineToGas, fractionalCount),
                nameof(Rankine) when input is CelsiusString castInput => Parser(castInput.Temperature, CelsiusConverter.CelsiusToRankine, fractionalCount),
                nameof(Rankine) when input is FahrenheitString castInput => Parser(castInput.Temperature, FahrenheitConverter.FahrenheitToRankine, fractionalCount),
                nameof(Rankine) when input is KelvinString castInput => Parser(castInput.Temperature, KelvinConverter.KelvinToRankine, fractionalCount),
                nameof(Rankine) when input is GasString castInput => Parser(castInput.Temperature, GasConverter.GasToRankine, fractionalCount),
                nameof(Rankine) when input is RankineString castInput => Parser(castInput.Temperature, RankineConverter.RankineToRankine, fractionalCount),
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
