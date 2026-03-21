namespace Converter.Temperature.Extensions.To.Réaumur;

using System;
using Converters.Celsius;
using Converters.Delisle;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Newton;
using Converters.Rankine;
using Converters.Réaumur;
using Converters.Rømer;
using Helpers;
using Types.Celsius;
using Types.Delisle;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Newton;
using Types.Rankine;
using Types.Réaumur;
using Types.Rømer;

/// <summary>
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(CelsiusDoubleConversions.CelsiusToRéaumur(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this DelisleDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(DelisleDoubleConversions.DelisleToRéaumur(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            FahrenheitDoubleConversions.FahrenheitToRéaumur(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(GasDoubleConversion.GasToRéaumur(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(KelvinDoubleConversions.KelvinToRéaumur(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Newton <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this NewtonDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(NewtonDoubleConversions.NewtonToRéaumur(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RankineDoubleConversions.RankineToRéaumur(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Réaumur <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this RéaumurDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RéaumurDoubleConversions.RéaumurToRéaumur(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Réaumur <see langword="double" /> result.
    /// </returns>
    public static double ToRéaumur(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RømerDoubleConversions.RømerToRéaumur(input.Temperature), fractionalCount);
    }
}
