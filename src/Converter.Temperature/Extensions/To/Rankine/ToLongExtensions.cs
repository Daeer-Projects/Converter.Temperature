using System;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Rankine;

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

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rankine <see langword="long" /> result.
    /// </returns>
    public static long ToRankine(
        this RømerLong input)
    {
        return RømerLongConversions.RømerToRankine(input.Temperature);
    }
}
