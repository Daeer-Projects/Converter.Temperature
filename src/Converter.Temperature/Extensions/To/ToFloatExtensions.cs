namespace Converter.Temperature.Extensions.To;

using System;
using BaseTypes;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using Helpers;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="float" /> extensions.
/// </summary>
public static class ToFloatExtensions
{
    /// <summary>
    ///     Converts the float input to the correct float value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static float To<TInput>(
        this FloatBase input,
        int fractionalCount = -1)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToGas(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToRømer(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToRømer(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToRømer(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToRømer(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToRømer(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToRømer(castInput.Temperature),
                fractionalCount),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
