﻿namespace Converter.Temperature.Extensions.To
{
    using System;
    using System.Globalization;
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
            int.TryParse(
                Celsius.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this FahrenheitInt input)
        {
            int.TryParse(
                Math.Round(Fahrenheit.FahrenheitToCelsius(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this GasInt input)
        {
            int.TryParse(
                Gas.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this KelvinInt input)
        {
            var convertedTemp = Math.Round(Kelvin.KelvinToCelsius(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this RankineInt input)
        {
            var convertedTemp = Math.Round(Rankine.RankineToCelsius(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this CelsiusInt input)
        {
            var convertedTemp = Math.Round(Celsius.CelsiusToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this FahrenheitInt input)
        {
            int.TryParse(
                Fahrenheit.FahrenheitToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this GasInt input)
        {
            int.TryParse(
                Gas.GasToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this KelvinInt input)
        {
            var convertedTemp = Math.Round(Kelvin.KelvinToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this RankineInt input)
        {
            var convertedTemp = Math.Round(Rankine.RankineToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this CelsiusInt input)
        {
            int.TryParse(
                Celsius.CelsiusToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this FahrenheitInt input)
        {
            int.TryParse(
                Fahrenheit.FahrenheitToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this GasInt input)
        {
            int.TryParse(
                Gas.GasToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this KelvinInt input)
        {
            int.TryParse(
                Kelvin.KelvinToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this RankineInt input)
        {
            int.TryParse(
                Rankine.RankineToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this CelsiusInt input)
        {
            var convertedTemp = Math.Round(Celsius.CelsiusToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this FahrenheitInt input)
        {
            int.TryParse(
                Math.Round(Fahrenheit.FahrenheitToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this GasInt input)
        {
            int.TryParse(
                Math.Round(Gas.GasToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this KelvinInt input)
        {
            int.TryParse(
                Kelvin.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this RankineInt input)
        {
            int.TryParse(
                Math.Round(Rankine.RankineToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this CelsiusInt input)
        {
            var convertedTemp = Math.Round(Celsius.CelsiusToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this FahrenheitInt input)
        {
            int.TryParse(
                Math.Round(Fahrenheit.FahrenheitToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this GasInt input)
        {
            int.TryParse(
                Math.Round(Gas.GasToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this KelvinInt input)
        {
            int.TryParse(
                Math.Round(Kelvin.KelvinToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Rankine <paramref name="input"/> to Rankine
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Rankine <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this RankineInt input)
        {
            int.TryParse(
                Rankine.RankineToRankine(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }
    }
}