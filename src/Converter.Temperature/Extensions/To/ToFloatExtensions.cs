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
            return FloatParser(CelsiusConverter.CelsiusToCelsius(input.Temperature));
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
            return FloatParser(FahrenheitConverter.FahrenheitToCelsius(input.Temperature));
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
            return FloatParser(GasConverter.GasToCelsius(input.Temperature));
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
            return (float)Math.Round(FloatParser(KelvinConverter.KelvinToCelsius(input.Temperature)), 2);
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
            return (float)Math.Round(FloatParser(RankineConverter.RankineToCelsius(input.Temperature)), 2);
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
            return FloatParser(CelsiusConverter.CelsiusToFahrenheit(input.Temperature));
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
            return FloatParser(FahrenheitConverter.FahrenheitToFahrenheit(input.Temperature));
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
            return FloatParser(GasConverter.GasToFahrenheit(input.Temperature));
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
            return (float)Math.Round(FloatParser(KelvinConverter.KelvinToFahrenheit(input.Temperature)), 2);
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
            return FloatParser(RankineConverter.RankineToFahrenheit(input.Temperature));
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
            return FloatParser(CelsiusConverter.CelsiusToGas(input.Temperature));
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
            return FloatParser(FahrenheitConverter.FahrenheitToGas(input.Temperature));
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
            return FloatParser(GasConverter.GasToGas(input.Temperature));
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
            return FloatParser(KelvinConverter.KelvinToGas(input.Temperature));
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
            return FloatParser(RankineConverter.RankineToGas(input.Temperature));
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
            return FloatParser(CelsiusConverter.CelsiusToKelvin(input.Temperature));
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
            return FloatParser(FahrenheitConverter.FahrenheitToKelvin(input.Temperature));
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
            return FloatParser(GasConverter.GasToKelvin(input.Temperature));
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
            return FloatParser(KelvinConverter.KelvinToKelvin(input.Temperature));
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
            return FloatParser(RankineConverter.RankineToKelvin(input.Temperature));
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
            return FloatParser(CelsiusConverter.CelsiusToRankine(input.Temperature));
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
            return FloatParser(FahrenheitConverter.FahrenheitToRankine(input.Temperature));
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
            return FloatParser(GasConverter.GasToRankine(input.Temperature));
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
            return FloatParser(KelvinConverter.KelvinToRankine(input.Temperature));
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
            return FloatParser(RankineConverter.RankineToRankine(input.Temperature));
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
                nameof(Celsius) when input is CelsiusFloat castInput => FloatParser(CelsiusConverter.CelsiusToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is FahrenheitFloat castInput => FloatParser(FahrenheitConverter.FahrenheitToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is KelvinFloat castInput => FloatParser(KelvinConverter.KelvinToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is GasFloat castInput => FloatParser(GasConverter.GasToCelsius(castInput.Temperature)),
                nameof(Celsius) when input is RankineFloat castInput => FloatParser(RankineConverter.RankineToCelsius(castInput.Temperature)),
                nameof(Fahrenheit) when input is CelsiusFloat castInput => FloatParser(CelsiusConverter.CelsiusToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is FahrenheitFloat castInput => FloatParser(FahrenheitConverter.FahrenheitToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is KelvinFloat castInput => FloatParser(KelvinConverter.KelvinToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is GasFloat castInput => FloatParser(GasConverter.GasToFahrenheit(castInput.Temperature)),
                nameof(Fahrenheit) when input is RankineFloat castInput => FloatParser(RankineConverter.RankineToFahrenheit(castInput.Temperature)),
                nameof(Kelvin) when input is CelsiusFloat castInput => FloatParser(CelsiusConverter.CelsiusToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is FahrenheitFloat castInput => FloatParser(FahrenheitConverter.FahrenheitToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is KelvinFloat castInput => FloatParser(KelvinConverter.KelvinToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is GasFloat castInput => FloatParser(GasConverter.GasToKelvin(castInput.Temperature)),
                nameof(Kelvin) when input is RankineFloat castInput => FloatParser(RankineConverter.RankineToKelvin(castInput.Temperature)),
                nameof(Gas) when input is CelsiusFloat castInput => FloatParser(CelsiusConverter.CelsiusToGas(castInput.Temperature)),
                nameof(Gas) when input is FahrenheitFloat castInput => FloatParser(FahrenheitConverter.FahrenheitToGas(castInput.Temperature)),
                nameof(Gas) when input is KelvinFloat castInput => FloatParser(KelvinConverter.KelvinToGas(castInput.Temperature)),
                nameof(Gas) when input is GasFloat castInput => FloatParser(GasConverter.GasToGas(castInput.Temperature)),
                nameof(Gas) when input is RankineFloat castInput => FloatParser(RankineConverter.RankineToGas(castInput.Temperature)),
                nameof(Rankine) when input is CelsiusFloat castInput => FloatParser(CelsiusConverter.CelsiusToRankine(castInput.Temperature)),
                nameof(Rankine) when input is FahrenheitFloat castInput => FloatParser(FahrenheitConverter.FahrenheitToRankine(castInput.Temperature)),
                nameof(Rankine) when input is KelvinFloat castInput => FloatParser(KelvinConverter.KelvinToRankine(castInput.Temperature)),
                nameof(Rankine) when input is GasFloat castInput => FloatParser(GasConverter.GasToRankine(castInput.Temperature)),
                nameof(Rankine) when input is RankineFloat castInput => FloatParser(RankineConverter.RankineToRankine(castInput.Temperature)),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }

        private static float FloatParser(double temp)
        {
            float.TryParse(temp.ToString(CultureInfo.InvariantCulture), out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return convertedTemp;
        }
    }
}