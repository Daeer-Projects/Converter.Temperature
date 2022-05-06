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
    /// The to <see langword="float"/> extensions.
    /// </summary>
    public static class ToFloatExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(CelsiusFloatConversions.CelsiusToCelsius(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(FahrenheitFloatConversions.FahrenheitToCelsius(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this GasFloat input, int fractionalCount = -1)
{
            return Rounder(Parser(GasDoubleConversion.GasToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinDoubleConversions.KelvinToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineDoubleConversions.RankineToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The CelsiusDoubleConversions <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(CelsiusFloatConversions.CelsiusToFahrenheit(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The DoubleFahrenheitConversions <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(FahrenheitFloatConversions.FahrenheitToFahrenheit(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The DoubleFahrenheitConversions <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasDoubleConversion.GasToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The DoubleFahrenheitConversions <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinDoubleConversions.KelvinToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to CelsiusDoubleConversions
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The DoubleFahrenheitConversions <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineDoubleConversions.RankineToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(CelsiusFloatConversions.CelsiusToGas(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(FahrenheitFloatConversions.FahrenheitToGas(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasDoubleConversion.GasToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinDoubleConversions.KelvinToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineDoubleConversions.RankineToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(CelsiusFloatConversions.CelsiusToKelvin(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(FahrenheitFloatConversions.FahrenheitToKelvin(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasDoubleConversion.GasToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinDoubleConversions.KelvinToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input" /> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineDoubleConversions.RankineToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(CelsiusFloatConversions.CelsiusToRankine(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the CelsiusDoubleConversions <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(FahrenheitFloatConversions.FahrenheitToRankine(input.Temperature), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasDoubleConversion.GasToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinDoubleConversions.KelvinToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineDoubleConversions.RankineToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the float input to the correct float value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static float To<TInput>(this FloatBase input, int fractionalCount = -1)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusFloat castInput => Rounder(CelsiusFloatConversions.CelsiusToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is FahrenheitFloat castInput => Rounder(FahrenheitFloatConversions.FahrenheitToCelsius(castInput.Temperature), fractionalCount),
                nameof(Celsius) when input is KelvinFloat castInput => Rounder(Parser(KelvinDoubleConversions.KelvinToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Celsius) when input is GasFloat castInput => Rounder(Parser(GasDoubleConversion.GasToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Celsius) when input is RankineFloat castInput => Rounder(Parser(RankineDoubleConversions.RankineToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is CelsiusFloat castInput => Rounder(CelsiusFloatConversions.CelsiusToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is FahrenheitFloat castInput => Rounder(FahrenheitFloatConversions.FahrenheitToFahrenheit(castInput.Temperature), fractionalCount),
                nameof(Fahrenheit) when input is KelvinFloat castInput => Rounder(Parser(KelvinDoubleConversions.KelvinToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is GasFloat castInput => Rounder(Parser(GasDoubleConversion.GasToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is RankineFloat castInput => Rounder(Parser(RankineDoubleConversions.RankineToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is CelsiusFloat castInput => Rounder(CelsiusFloatConversions.CelsiusToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is FahrenheitFloat castInput => Rounder(FahrenheitFloatConversions.FahrenheitToKelvin(castInput.Temperature), fractionalCount),
                nameof(Kelvin) when input is KelvinFloat castInput => Rounder(Parser(KelvinDoubleConversions.KelvinToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is GasFloat castInput => Rounder(Parser(GasDoubleConversion.GasToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is RankineFloat castInput => Rounder(Parser(RankineDoubleConversions.RankineToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is CelsiusFloat castInput => Rounder(CelsiusFloatConversions.CelsiusToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is FahrenheitFloat castInput => Rounder(FahrenheitFloatConversions.FahrenheitToGas(castInput.Temperature), fractionalCount),
                nameof(Gas) when input is KelvinFloat castInput => Rounder(Parser(KelvinDoubleConversions.KelvinToGas(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is GasFloat castInput => Rounder(Parser(GasDoubleConversion.GasToGas(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is RankineFloat castInput => Rounder(Parser(RankineDoubleConversions.RankineToGas(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is CelsiusFloat castInput => Rounder(CelsiusFloatConversions.CelsiusToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is FahrenheitFloat castInput => Rounder(FahrenheitFloatConversions.FahrenheitToRankine(castInput.Temperature), fractionalCount),
                nameof(Rankine) when input is KelvinFloat castInput => Rounder(Parser(KelvinDoubleConversions.KelvinToRankine(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is GasFloat castInput => Rounder(Parser(GasDoubleConversion.GasToRankine(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is RankineFloat castInput => Rounder(Parser(RankineDoubleConversions.RankineToRankine(castInput.Temperature)), fractionalCount),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static float Parser(double temp)
        {
            float.TryParse(temp.ToString(CultureInfo.InvariantCulture), out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return convertedTemp;
        }

        private static float Rounder(float input, int fractionalCount = -1)
        {
            if (fractionalCount < 0)
                return input;

            return (float)Math.Round(input, fractionalCount);
        }
    }
}