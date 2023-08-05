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
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Double input to the correct double value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static double To<TInput>(
        this DoubleBase input,
        int fractionalCount = -1)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToGas(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToRømer(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToRankine(castInput.Temperature),
                fractionalCount),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
