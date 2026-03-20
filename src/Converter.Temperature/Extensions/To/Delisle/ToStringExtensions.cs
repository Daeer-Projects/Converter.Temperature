namespace Converter.Temperature.Extensions.To.Delisle;

using System;
using Converters.Celsius;
using Converters.Delisle;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using Helpers;
using Types.Celsius;
using Types.Delisle;
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
    ///     Converts the Celsius <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="string" /> result.
    /// </returns>
    public static string ToDelisle(
        this CelsiusString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            CelsiusDoubleConversions.CelsiusToDelisle,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="string" /> result.
    /// </returns>
    public static string ToDelisle(
        this FahrenheitString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            FahrenheitDoubleConversions.FahrenheitToDelisle,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Delisle <see langword="string" /> result.
    /// </returns>
    public static string ToDelisle(
        this GasString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            GasDoubleConversion.GasToDelisle,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="string" /> result.
    /// </returns>
    public static string ToDelisle(
        this KelvinString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            KelvinDoubleConversions.KelvinToDelisle,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="string" /> result.
    /// </returns>
    public static string ToDelisle(
        this RankineString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            RankineDoubleConversions.RankineToDelisle,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="string" /> result.
    /// </returns>
    public static string ToDelisle(
        this RømerString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            RømerDoubleConversions.RømerToDelisle,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <returns>
    ///     The Delisle <see langword="string" /> result.
    /// </returns>
    public static string ToDelisle(
        this DelisleString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            DelisleDoubleConversions.DelisleToDelisle,
            fractionalCount);
    }
}
