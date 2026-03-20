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
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="double" /> result.
    /// </returns>
    public static double ToDelisle(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            CelsiusDoubleConversions.CelsiusToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="double" /> result.
    /// </returns>
    public static double ToDelisle(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            FahrenheitDoubleConversions.FahrenheitToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Delisle <see langword="double" /> result.
    /// </returns>
    public static double ToDelisle(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            GasDoubleConversion.GasToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="double" /> result.
    /// </returns>
    public static double ToDelisle(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            KelvinDoubleConversions.KelvinToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="double" /> result.
    /// </returns>
    public static double ToDelisle(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RankineDoubleConversions.RankineToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="double" /> result.
    /// </returns>
    public static double ToDelisle(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RømerDoubleConversions.RømerToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <returns>
    ///     The Delisle <see langword="double" /> result.
    /// </returns>
    public static double ToDelisle(
        this DelisleDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            DelisleDoubleConversions.DelisleToDelisle(input.Temperature),
            fractionalCount);
    }
}
