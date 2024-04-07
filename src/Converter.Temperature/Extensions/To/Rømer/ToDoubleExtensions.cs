namespace Converter.Temperature.Extensions.To.Rømer;

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
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="double" /> result.
    /// </returns>
    public static double ToRømer(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(CelsiusDoubleConversions.CelsiusToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="double" /> result.
    /// </returns>
    public static double ToRømer(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            FahrenheitDoubleConversions.FahrenheitToRømer(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="double" /> result.
    /// </returns>
    public static double ToRømer(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(GasDoubleConversion.GasToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="double" /> result.
    /// </returns>
    public static double ToRømer(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(KelvinDoubleConversions.KelvinToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="double" /> result.
    /// </returns>
    public static double ToRømer(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RankineDoubleConversions.RankineToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="double" /> result.
    /// </returns>
    public static double ToRømer(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RømerDoubleConversions.RømerToRømer(input.Temperature), fractionalCount);
    }
}
