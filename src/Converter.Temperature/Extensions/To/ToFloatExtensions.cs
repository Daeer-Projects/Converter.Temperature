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
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this CelsiusFloat input)
        {
            float.TryParse(
                CelsiusConverter.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this FahrenheitFloat input)
        {
            var result = input.Temperature;
            if (float.TryParse(
                FahrenheitConverter.FahrenheitToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp))
            {
                result = convertedTemp;
            }

            return result;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this GasFloat input)
        {
            float.TryParse(
                GasConverter.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this KelvinFloat input)
        {
            float.TryParse(
                KelvinConverter.KelvinToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return (float)Math.Round(convertedTemp, 2);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="float"/> result.
        /// </returns>
        public static float ToCelsius(this RankineFloat input)
        {
            float.TryParse(
                RankineConverter.RankineToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return (float)Math.Round(convertedTemp, 2);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this CelsiusFloat input)
        {
            float.TryParse(
                CelsiusConverter.CelsiusToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this FahrenheitFloat input)
        {
            float.TryParse(
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
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this GasFloat input)
        {
            float.TryParse(
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
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this KelvinFloat input)
        {
            float.TryParse(
                KelvinConverter.KelvinToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return (float)Math.Round(convertedTemp, 2);
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to FahrenheitConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter <see langword="float"/> result.
        /// </returns>
        public static float ToFahrenheit(this RankineFloat input)
        {
            float.TryParse(
                RankineConverter.RankineToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to GasConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this CelsiusFloat input)
        {
            float.TryParse(
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
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this FahrenheitFloat input)
        {
            float.TryParse(
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
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this GasFloat input)
        {
            float.TryParse(
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
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this KelvinFloat input)
        {
            float.TryParse(
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
        /// The GasConverter <see langword="float"/> result.
        /// </returns>
        public static float ToGas(this RankineFloat input)
        {
            float.TryParse(
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
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this CelsiusFloat input)
        {
            float.TryParse(
                CelsiusConverter.CelsiusToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this FahrenheitFloat input)
        {
            float.TryParse(
                FahrenheitConverter.FahrenheitToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this GasFloat input)
        {
            float.TryParse(
                GasConverter.GasToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this KelvinFloat input)
        {
            float.TryParse(
                KelvinConverter.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input" /> to KelvinConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// If calculated value is beyond the limits of the type.
        /// </exception>
        /// <returns>
        /// The KelvinConverter <see langword="float"/> result.
        /// </returns>
        public static float ToKelvin(this RankineFloat input)
        {
            float.TryParse(
                RankineConverter.RankineToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this CelsiusFloat input)
        {
            float.TryParse(
                CelsiusConverter.CelsiusToRankine(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the FahrenheitConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this FahrenheitFloat input)
        {
            float.TryParse(
                FahrenheitConverter.FahrenheitToRankine(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the GasConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this GasFloat input)
        {
            float.TryParse(
                GasConverter.GasToRankine(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the KelvinConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this KelvinFloat input)
        {
            float.TryParse(
                KelvinConverter.KelvinToRankine(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the RankineConverter <paramref name="input"/> to RankineConverter
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The RankineConverter <see langword="float"/> result.
        /// </returns>
        public static float ToRankine(this RankineFloat input)
        {
            float.TryParse(
                RankineConverter.RankineToRankine(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Converts the float input to the correct float value.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static float To<TInput>(this FloatBase input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) when input is CelsiusFloat castInput => float.Parse(CelsiusConverter.CelsiusToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is FahrenheitFloat castInput => float.Parse(FahrenheitConverter.FahrenheitToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is KelvinFloat castInput => float.Parse(KelvinConverter.KelvinToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is GasFloat castInput => float.Parse(GasConverter.GasToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Celsius) when input is RankineFloat castInput => float.Parse(RankineConverter.RankineToCelsius(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is CelsiusFloat castInput => float.Parse(CelsiusConverter.CelsiusToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is FahrenheitFloat castInput => float.Parse(FahrenheitConverter.FahrenheitToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is KelvinFloat castInput => float.Parse(KelvinConverter.KelvinToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is GasFloat castInput => float.Parse(GasConverter.GasToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Fahrenheit) when input is RankineFloat castInput => float.Parse(RankineConverter.RankineToFahrenheit(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is CelsiusFloat castInput => float.Parse(CelsiusConverter.CelsiusToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is FahrenheitFloat castInput => float.Parse(FahrenheitConverter.FahrenheitToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is KelvinFloat castInput => float.Parse(KelvinConverter.KelvinToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is GasFloat castInput => float.Parse(GasConverter.GasToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Kelvin) when input is RankineFloat castInput => float.Parse(RankineConverter.RankineToKelvin(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is CelsiusFloat castInput => float.Parse(CelsiusConverter.CelsiusToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is FahrenheitFloat castInput => float.Parse(FahrenheitConverter.FahrenheitToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is KelvinFloat castInput => float.Parse(KelvinConverter.KelvinToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is GasFloat castInput => float.Parse(GasConverter.GasToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Gas) when input is RankineFloat castInput => float.Parse(RankineConverter.RankineToGas(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is CelsiusFloat castInput => float.Parse(CelsiusConverter.CelsiusToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is FahrenheitFloat castInput => float.Parse(FahrenheitConverter.FahrenheitToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is KelvinFloat castInput => float.Parse(KelvinConverter.KelvinToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is GasFloat castInput => float.Parse(GasConverter.GasToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                nameof(Rankine) when input is RankineFloat castInput => float.Parse(RankineConverter.RankineToRankine(castInput.Temperature).ToString(CultureInfo.InvariantCulture)),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}