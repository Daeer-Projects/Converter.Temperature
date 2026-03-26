using System;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Delisle;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Newton;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Réaumur;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Delisle;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Newton;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Réaumur;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Rankine;

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

    /// <summary>
    ///     Converts the Newton <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this NewtonInt input)
    {
        return NewtonIntConversions.NewtonToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this DelisleInt input)
    {
        return DelisleIntConversions.DelisleToRankine(input.Temperature);
    }

    /// <summary>
    ///     Converts the Réaumur <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rankine <see langword="int" /> result.
    /// </returns>
    public static int ToRankine(
        this RéaumurInt input)
    {
        return RéaumurIntConversions.RéaumurToRankine(input.Temperature);
    }
}
