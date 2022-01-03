namespace Converter.Temperature.Extensions.To
{
using System;
    using System.Globalization;
using Converter.Temperature.BaseTypes;
    using Converter.Temperature.TemperatureTypes;
    using Converter.Temperature.Types.Celsius;
    using Converter.Temperature.Types.Fahrenheit;
    using Converter.Temperature.Types.Gas;
    using Converter.Temperature.Types.Kelvin;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = CelsiusConverter.CelsiusToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = FahrenheitConverter.FahrenheitToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = GasConverter.GasToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = KelvinConverter.KelvinToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = RankineConverter.RankineToRankine(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
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
                nameof(Celsius) when input is CelsiusString castInput => CelsiusConverter.CelsiusToCelsius(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Celsius) when input is FahrenheitString castInput => FahrenheitConverter.FahrenheitToCelsius(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Celsius) when input is KelvinString castInput => KelvinConverter.KelvinToCelsius(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Celsius) when input is GasString castInput => GasConverter.GasToCelsius(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Celsius) when input is RankineString castInput => RankineConverter.RankineToCelsius(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Fahrenheit) when input is CelsiusString castInput => CelsiusConverter.CelsiusToFahrenheit(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Fahrenheit) when input is FahrenheitString castInput => FahrenheitConverter.FahrenheitToFahrenheit(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Fahrenheit) when input is KelvinString castInput => KelvinConverter.KelvinToFahrenheit(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Fahrenheit) when input is GasString castInput => GasConverter.GasToFahrenheit(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Fahrenheit) when input is RankineString castInput => RankineConverter.RankineToFahrenheit(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Kelvin) when input is CelsiusString castInput => CelsiusConverter.CelsiusToKelvin(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Kelvin) when input is FahrenheitString castInput => FahrenheitConverter.FahrenheitToKelvin(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Kelvin) when input is KelvinString castInput => KelvinConverter.KelvinToKelvin(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Kelvin) when input is GasString castInput => GasConverter.GasToKelvin(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Kelvin) when input is RankineString castInput => RankineConverter.RankineToKelvin(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Gas) when input is CelsiusString castInput => CelsiusConverter.CelsiusToGas(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Gas) when input is FahrenheitString castInput => FahrenheitConverter.FahrenheitToGas(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Gas) when input is KelvinString castInput => KelvinConverter.KelvinToGas(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Gas) when input is GasString castInput => GasConverter.GasToGas(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Gas) when input is RankineString castInput => RankineConverter.RankineToGas(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Rankine) when input is CelsiusString castInput => CelsiusConverter.CelsiusToRankine(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Rankine) when input is FahrenheitString castInput => FahrenheitConverter.FahrenheitToRankine(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Rankine) when input is KelvinString castInput => KelvinConverter.KelvinToRankine(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Rankine) when input is GasString castInput => GasConverter.GasToRankine(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                nameof(Rankine) when input is RankineString castInput => RankineConverter.RankineToRankine(double.Parse(castInput.Temperature)).ToString(CultureInfo.InvariantCulture),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}
