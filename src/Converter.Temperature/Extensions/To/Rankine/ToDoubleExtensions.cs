using System;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.Extensions.To.Helpers;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Rankine;

/// <summary>
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            CelsiusDoubleConversions.CelsiusToRankine(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            FahrenheitDoubleConversions.FahrenheitToRankine(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(GasDoubleConversion.GasToRankine(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(KelvinDoubleConversions.KelvinToRankine(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RankineDoubleConversions.RankineToRankine(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RømerDoubleConversions.RømerToRankine(input.Temperature), fractionalCount);
    }
}
