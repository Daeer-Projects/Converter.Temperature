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
///     The to string extensions.
/// </summary>
public static class ToStringExtensions
{
    /// <summary>
    ///     Converts the String input to the correct string value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static string To<TInput>(
        this StringBase input,
        int fractionalCount = -1)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToCelsius,
                fractionalCount),
            nameof(Celsius) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToCelsius,
                fractionalCount),
            nameof(Celsius) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToCelsius,
                fractionalCount),
            nameof(Celsius) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToCelsius,
                fractionalCount),
            nameof(Celsius) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToCelsius,
                fractionalCount),
            nameof(Celsius) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToCelsius,
                fractionalCount),
            nameof(Fahrenheit) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToFahrenheit,
                fractionalCount),
            nameof(Fahrenheit) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToFahrenheit,
                fractionalCount),
            nameof(Fahrenheit) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToFahrenheit,
                fractionalCount),
            nameof(Fahrenheit) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToFahrenheit,
                fractionalCount),
            nameof(Fahrenheit) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToFahrenheit,
                fractionalCount),
            nameof(Fahrenheit) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToFahrenheit,
                fractionalCount),
            nameof(Kelvin) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToKelvin,
                fractionalCount),
            nameof(Kelvin) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToKelvin,
                fractionalCount),
            nameof(Kelvin) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToKelvin,
                fractionalCount),
            nameof(Kelvin) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToKelvin,
                fractionalCount),
            nameof(Kelvin) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToKelvin,
                fractionalCount),
            nameof(Kelvin) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToKelvin,
                fractionalCount),
            nameof(Gas) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToGas,
                fractionalCount),
            nameof(Gas) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToGas,
                fractionalCount),
            nameof(Gas) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToGas,
                fractionalCount),
            nameof(Gas) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToGas,
                fractionalCount),
            nameof(Gas) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToGas,
                fractionalCount),
            nameof(Gas) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToGas,
                fractionalCount),
            nameof(Rankine) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToRankine,
                fractionalCount),
            nameof(Rankine) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToRankine,
                fractionalCount),
            nameof(Rankine) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToRankine,
                fractionalCount),
            nameof(Rankine) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToRankine,
                fractionalCount),
            nameof(Rankine) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToRankine,
                fractionalCount),
            nameof(Rankine) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToRankine,
                fractionalCount),
            nameof(Rømer) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToRømer,
                fractionalCount),
            nameof(Rømer) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToRømer,
                fractionalCount),
            nameof(Rømer) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToRømer,
                fractionalCount),
            nameof(Rømer) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToRømer,
                fractionalCount),
            nameof(Rømer) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToRømer,
                fractionalCount),
            nameof(Rømer) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToRømer,
                fractionalCount),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}