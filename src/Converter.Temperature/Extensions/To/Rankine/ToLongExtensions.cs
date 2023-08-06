namespace Converter.Temperature.Extensions.To.Rankine;

using System;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;

/// <summary>
///     The to <see langword="long" /> extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rankine <see langword="long" /> result.
    /// </returns>
    public static long ToRankine(
        this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rankine <see langword="long" /> result.
    /// </returns>
    public static long ToRankine(
        this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Rankine <see langword="long" /> result.
    /// </returns>
    public static long ToRankine(
        this GasLong input)
    {
        return GasLongConversions.GasToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rankine <see langword="long" /> result.
    /// </returns>
    public static long ToRankine(
        this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rankine <see langword="long" /> result.
    /// </returns>
    public static long ToRankine(
        this RankineLong input)
    {
        return RankineLongConversions.RankineToRankine(input.Temperature);
    }
}
