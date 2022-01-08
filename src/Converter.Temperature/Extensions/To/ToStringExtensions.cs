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
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this CelsiusString input)
        {
            return StringParser(input.Temperature, CelsiusConverter.CelsiusToCelsius);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this FahrenheitString input)
        {
            return StringParser(input.Temperature, FahrenheitConverter.FahrenheitToCelsius);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this GasString input)
        {
            return StringParser(input.Temperature, GasConverter.GasToCelsius);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this KelvinString input)
        {
            return StringParser(input.Temperature, KelvinConverter.KelvinToCelsius);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this RankineString input)
        {
            return StringParser(input.Temperature, RankineConverter.RankineToCelsius);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this CelsiusString input)
        {
            return StringParser(input.Temperature, CelsiusConverter.CelsiusToFahrenheit);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this FahrenheitString input)
        {
            return StringParser(input.Temperature, FahrenheitConverter.FahrenheitToFahrenheit);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this GasString input)
        {
            return StringParser(input.Temperature, GasConverter.GasToFahrenheit);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this KelvinString input)
        {
            return StringParser(input.Temperature, KelvinConverter.KelvinToFahrenheit);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter string result.
        /// </returns>
        public static string ToFahrenheit(this RankineString input)
        {
            return StringParser(input.Temperature, RankineConverter.RankineToFahrenheit);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this CelsiusString input)
        {
            return StringParser(input.Temperature, CelsiusConverter.CelsiusToGas);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this FahrenheitString input)
        {
            return StringParser(input.Temperature, FahrenheitConverter.FahrenheitToGas);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this GasString input)
        {
            return StringParser(input.Temperature, GasConverter.GasToGas);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this KelvinString input)
        {
            return StringParser(input.Temperature, KelvinConverter.KelvinToGas);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter string result.
        /// </returns>
        public static string ToGas(this RankineString input)
        {
            return StringParser(input.Temperature, RankineConverter.RankineToGas);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this CelsiusString input)
        {
            return StringParser(input.Temperature, CelsiusConverter.CelsiusToKelvin);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this FahrenheitString input)
        {
            return StringParser(input.Temperature, FahrenheitConverter.FahrenheitToKelvin);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this GasString input)
        {
            return StringParser(input.Temperature, GasConverter.GasToKelvin);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this KelvinString input)
        {
            return StringParser(input.Temperature, KelvinConverter.KelvinToKelvin);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter string result.
        /// </returns>
        public static string ToKelvin(this RankineString input)
        {
            return StringParser(input.Temperature, RankineConverter.RankineToKelvin);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this CelsiusString input)
        {
            return StringParser(input.Temperature, CelsiusConverter.CelsiusToRankine);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this FahrenheitString input)
        {
            return StringParser(input.Temperature, FahrenheitConverter.FahrenheitToRankine);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this GasString input)
        {
            return StringParser(input.Temperature, GasConverter.GasToRankine);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this KelvinString input)
        {
            return StringParser(input.Temperature, KelvinConverter.KelvinToRankine);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter string result.
        /// </returns>
        public static string ToRankine(this RankineString input)
        {
            return StringParser(input.Temperature, RankineConverter.RankineToRankine);
        }

        /// <summary>
        /// Converts the String input to the correct string value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static string To<TInput>(this StringBase input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusString castInput => StringParser(castInput.Temperature, CelsiusConverter.CelsiusToCelsius),
                nameof(Celsius) when input is FahrenheitString castInput => StringParser(castInput.Temperature, FahrenheitConverter.FahrenheitToCelsius),
                nameof(Celsius) when input is KelvinString castInput => StringParser(castInput.Temperature, KelvinConverter.KelvinToCelsius),
                nameof(Celsius) when input is GasString castInput => StringParser(castInput.Temperature, GasConverter.GasToCelsius),
                nameof(Celsius) when input is RankineString castInput => StringParser(castInput.Temperature, RankineConverter.RankineToCelsius),
                nameof(Fahrenheit) when input is CelsiusString castInput => StringParser(castInput.Temperature, CelsiusConverter.CelsiusToFahrenheit),
                nameof(Fahrenheit) when input is FahrenheitString castInput => StringParser(castInput.Temperature, FahrenheitConverter.FahrenheitToFahrenheit),
                nameof(Fahrenheit) when input is KelvinString castInput => StringParser(castInput.Temperature, KelvinConverter.KelvinToFahrenheit),
                nameof(Fahrenheit) when input is GasString castInput => StringParser(castInput.Temperature, GasConverter.GasToFahrenheit),
                nameof(Fahrenheit) when input is RankineString castInput => StringParser(castInput.Temperature, RankineConverter.RankineToFahrenheit),
                nameof(Kelvin) when input is CelsiusString castInput => StringParser(castInput.Temperature, CelsiusConverter.CelsiusToKelvin),
                nameof(Kelvin) when input is FahrenheitString castInput => StringParser(castInput.Temperature, FahrenheitConverter.FahrenheitToKelvin),
                nameof(Kelvin) when input is KelvinString castInput => StringParser(castInput.Temperature, KelvinConverter.KelvinToKelvin),
                nameof(Kelvin) when input is GasString castInput => StringParser(castInput.Temperature, GasConverter.GasToKelvin),
                nameof(Kelvin) when input is RankineString castInput => StringParser(castInput.Temperature, RankineConverter.RankineToKelvin),
                nameof(Gas) when input is CelsiusString castInput => StringParser(castInput.Temperature, CelsiusConverter.CelsiusToGas),
                nameof(Gas) when input is FahrenheitString castInput => StringParser(castInput.Temperature, FahrenheitConverter.FahrenheitToGas),
                nameof(Gas) when input is KelvinString castInput => StringParser(castInput.Temperature, KelvinConverter.KelvinToGas),
                nameof(Gas) when input is GasString castInput => StringParser(castInput.Temperature, GasConverter.GasToGas),
                nameof(Gas) when input is RankineString castInput => StringParser(castInput.Temperature, RankineConverter.RankineToGas),
                nameof(Rankine) when input is CelsiusString castInput => StringParser(castInput.Temperature, CelsiusConverter.CelsiusToRankine),
                nameof(Rankine) when input is FahrenheitString castInput => StringParser(castInput.Temperature, FahrenheitConverter.FahrenheitToRankine),
                nameof(Rankine) when input is KelvinString castInput => StringParser(castInput.Temperature, KelvinConverter.KelvinToRankine),
                nameof(Rankine) when input is GasString castInput => StringParser(castInput.Temperature, GasConverter.GasToRankine),
                nameof(Rankine) when input is RankineString castInput => StringParser(castInput.Temperature, RankineConverter.RankineToRankine),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static string StringParser(string temp, Func<double, double> methodToParse)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(temp, out var inputAsDouble))
            {
                convertedTemp = methodToParse(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }
    }
}
