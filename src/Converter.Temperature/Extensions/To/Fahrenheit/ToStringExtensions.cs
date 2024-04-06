namespace Converter.Temperature.Extensions.To.Fahrenheit;

using System;
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
    ///     Converts the Celsius <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit string result.
    /// </returns>
    public static string ToFahrenheit(
        this CelsiusString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            CelsiusDoubleConversions.CelsiusToFahrenheit,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit string result.
    /// </returns>
    public static string ToFahrenheit(
        this FahrenheitString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            FahrenheitDoubleConversions.FahrenheitToFahrenheit,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit string result.
    /// </returns>
    public static string ToFahrenheit(
        this GasString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, GasDoubleConversion.GasToFahrenheit, fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit string result.
    /// </returns>
    public static string ToFahrenheit(
        this KelvinString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            KelvinDoubleConversions.KelvinToFahrenheit,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit string result.
    /// </returns>
    public static string ToFahrenheit(
        this RankineString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            RankineDoubleConversions.RankineToFahrenheit,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit string result.
    /// </returns>
    public static string ToFahrenheit(
        this RømerString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, RømerDoubleConversions.RømerToFahrenheit, fractionalCount);
    }
}
