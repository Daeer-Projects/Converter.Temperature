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
    /// The to <see langword="float"/> extensions.
    /// </summary>
    public static class ToFloatExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(CelsiusConverter.CelsiusToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(FahrenheitConverter.FahrenheitToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this GasFloat input, int fractionalCount = -1)
{
            return Rounder(Parser(GasConverter.GasToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinConverter.KelvinToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineConverter.RankineToCelsius(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(CelsiusConverter.CelsiusToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(FahrenheitConverter.FahrenheitToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasConverter.GasToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinConverter.KelvinToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineConverter.RankineToFahrenheit(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(CelsiusConverter.CelsiusToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(FahrenheitConverter.FahrenheitToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasConverter.GasToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinConverter.KelvinToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineConverter.RankineToGas(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(CelsiusConverter.CelsiusToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(FahrenheitConverter.FahrenheitToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasConverter.GasToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinConverter.KelvinToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input" /> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// If calculated value is beyond the limits of the type.
        /// </exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineConverter.RankineToKelvin(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this CelsiusFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(CelsiusConverter.CelsiusToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this FahrenheitFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(FahrenheitConverter.FahrenheitToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this GasFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(GasConverter.GasToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this KelvinFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(KelvinConverter.KelvinToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this RankineFloat input, int fractionalCount = -1)
        {
            return Rounder(Parser(RankineConverter.RankineToRankine(input.Temperature)), fractionalCount);
        }

        /// <summary>
        /// Converts the float input to the correct float value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static float To<TInput>(this FloatBase input, int fractionalCount = -1)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusFloat castInput => Rounder(Parser(CelsiusConverter.CelsiusToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Celsius) when input is FahrenheitFloat castInput => Rounder(Parser(FahrenheitConverter.FahrenheitToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Celsius) when input is KelvinFloat castInput => Rounder(Parser(KelvinConverter.KelvinToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Celsius) when input is GasFloat castInput => Rounder(Parser(GasConverter.GasToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Celsius) when input is RankineFloat castInput => Rounder(Parser(RankineConverter.RankineToCelsius(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is CelsiusFloat castInput => Rounder(Parser(CelsiusConverter.CelsiusToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is FahrenheitFloat castInput => Rounder(Parser(FahrenheitConverter.FahrenheitToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is KelvinFloat castInput => Rounder(Parser(KelvinConverter.KelvinToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is GasFloat castInput => Rounder(Parser(GasConverter.GasToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Fahrenheit) when input is RankineFloat castInput => Rounder(Parser(RankineConverter.RankineToFahrenheit(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is CelsiusFloat castInput => Rounder(Parser(CelsiusConverter.CelsiusToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is FahrenheitFloat castInput => Rounder(Parser(FahrenheitConverter.FahrenheitToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is KelvinFloat castInput => Rounder(Parser(KelvinConverter.KelvinToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is GasFloat castInput => Rounder(Parser(GasConverter.GasToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Kelvin) when input is RankineFloat castInput => Rounder(Parser(RankineConverter.RankineToKelvin(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is CelsiusFloat castInput => Rounder(Parser(CelsiusConverter.CelsiusToGas(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is FahrenheitFloat castInput => Rounder(Parser(FahrenheitConverter.FahrenheitToGas(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is KelvinFloat castInput => Rounder(Parser(KelvinConverter.KelvinToGas(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is GasFloat castInput => Rounder(Parser(GasConverter.GasToGas(castInput.Temperature)), fractionalCount),
                nameof(Gas) when input is RankineFloat castInput => Rounder(Parser(RankineConverter.RankineToGas(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is CelsiusFloat castInput => Rounder(Parser(CelsiusConverter.CelsiusToRankine(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is FahrenheitFloat castInput => Rounder(Parser(FahrenheitConverter.FahrenheitToRankine(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is KelvinFloat castInput => Rounder(Parser(KelvinConverter.KelvinToRankine(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is GasFloat castInput => Rounder(Parser(GasConverter.GasToRankine(castInput.Temperature)), fractionalCount),
                nameof(Rankine) when input is RankineFloat castInput => Rounder(Parser(RankineConverter.RankineToRankine(castInput.Temperature)), fractionalCount),
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