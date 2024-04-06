namespace Converter.Temperature.Extensions.To.Rankine;

using System;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this GasInt input)
    {
        return GasIntConversions.GasToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this RankineInt input)
    {
        return RankineIntConversions.RankineToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this RømerInt input)
    {
        return RømerIntConversions.RømerToRankine(input.Temperature);
    }
}
