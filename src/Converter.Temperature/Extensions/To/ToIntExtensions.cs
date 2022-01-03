namespace Converter.Temperature.Extensions.To
{
    using System;
    using System.Globalization;
using Converter.Temperature.BaseTypes;
using Converter.Temperature.TemperatureTypes;
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
                CelsiusConverter.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this FahrenheitInt input)
        {
            int.TryParse(
                Math.Round(FahrenheitConverter.FahrenheitToCelsius(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this GasInt input)
        {
            int.TryParse(
                GasConverter.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this KelvinInt input)
        {
            var convertedTemp = Math.Round(KelvinConverter.KelvinToCelsius(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The Celsius <see langword="int"/> result.
        /// </returns>
        public static int ToCelsius(this RankineInt input)
        {
            int.TryParse(
                Math.Round(RankineConverter.RankineToCelsius(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var validTemp);
            return validTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this CelsiusInt input)
        {
            var convertedTemp = Math.Round(CelsiusConverter.CelsiusToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this FahrenheitInt input)
        {
            int.TryParse(
                FahrenheitConverter.FahrenheitToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this GasInt input)
        {
            int.TryParse(
                GasConverter.GasToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this KelvinInt input)
        {
            var convertedTemp = Math.Round(KelvinConverter.KelvinToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="int"/> result.
        /// </returns>
        public static int ToFahrenheit(this RankineInt input)
        {
            int.TryParse(
                Math.Round(RankineConverter.RankineToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var validTemp);
            return validTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this CelsiusInt input)
        {
            int.TryParse(
                CelsiusConverter.CelsiusToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this FahrenheitInt input)
        {
            int.TryParse(
                FahrenheitConverter.FahrenheitToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this GasInt input)
        {
            int.TryParse(
                GasConverter.GasToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this KelvinInt input)
        {
            int.TryParse(
                KelvinConverter.KelvinToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="int"/> result.
        /// </returns>
        public static int ToGas(this RankineInt input)
        {
            int.TryParse(
                RankineConverter.RankineToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this CelsiusInt input)
        {
            var convertedTemp = Math.Round(CelsiusConverter.CelsiusToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this FahrenheitInt input)
        {
            int.TryParse(
                Math.Round(FahrenheitConverter.FahrenheitToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The KelvinConverter <see langword="int"/> result.
        /// </returns>
        public static int ToKelvin(this GasInt input)
        {
            int.TryParse(
                Math.Round(GasConverter.GasToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
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
            int.TryParse(
                KelvinConverter.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
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
            int.TryParse(
                Math.Round(RankineConverter.RankineToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this CelsiusInt input)
        {
            var convertedTemp = Math.Round(CelsiusConverter.CelsiusToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture);
            if (!int.TryParse(convertedTemp, out var validTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);
            return validTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this FahrenheitInt input)
        {
            int.TryParse(
                Math.Round(FahrenheitConverter.FahrenheitToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The RankineConverter <see langword="int"/> result.
        /// </returns>
        public static int ToRankine(this GasInt input)
        {
            int.TryParse(
                Math.Round(GasConverter.GasToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
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
            int.TryParse(
                Math.Round(KelvinConverter.KelvinToRankine(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
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
            int.TryParse(
                RankineConverter.RankineToRankine(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
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
                nameof(Celsius) when input is CelsiusInt castInput => int.Parse(CelsiusConverter.CelsiusToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is FahrenheitInt castInput => int.Parse(FahrenheitConverter.FahrenheitToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is KelvinInt castInput => int.Parse(KelvinConverter.KelvinToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is GasInt castInput => int.Parse(GasConverter.GasToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is RankineInt castInput => int.Parse(RankineConverter.RankineToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is CelsiusInt castInput => int.Parse(CelsiusConverter.CelsiusToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is FahrenheitInt castInput => int.Parse(FahrenheitConverter.FahrenheitToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is KelvinInt castInput => int.Parse(KelvinConverter.KelvinToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is GasInt castInput => int.Parse(GasConverter.GasToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is RankineInt castInput => int.Parse(RankineConverter.RankineToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is CelsiusInt castInput => int.Parse(CelsiusConverter.CelsiusToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is FahrenheitInt castInput => int.Parse(FahrenheitConverter.FahrenheitToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is KelvinInt castInput => int.Parse(KelvinConverter.KelvinToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is GasInt castInput => int.Parse(GasConverter.GasToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is RankineInt castInput => int.Parse(RankineConverter.RankineToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is CelsiusInt castInput => int.Parse(CelsiusConverter.CelsiusToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is FahrenheitInt castInput => int.Parse(FahrenheitConverter.FahrenheitToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is KelvinInt castInput => int.Parse(KelvinConverter.KelvinToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is GasInt castInput => int.Parse(GasConverter.GasToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is RankineInt castInput => int.Parse(RankineConverter.RankineToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is CelsiusInt castInput => int.Parse(CelsiusConverter.CelsiusToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is FahrenheitInt castInput => int.Parse(FahrenheitConverter.FahrenheitToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is KelvinInt castInput => int.Parse(KelvinConverter.KelvinToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is GasInt castInput => int.Parse(GasConverter.GasToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is RankineInt castInput => int.Parse(RankineConverter.RankineToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}