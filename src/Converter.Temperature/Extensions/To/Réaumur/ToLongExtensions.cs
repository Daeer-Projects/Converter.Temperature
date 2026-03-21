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
///     The to <see langword="long" /> extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this DelisleLong input)
    {
        return DelisleLongConversions.DelisleToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this GasLong input)
    {
        return GasLongConversions.GasToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Newton <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this NewtonLong input)
    {
        return NewtonLongConversions.NewtonToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this RankineLong input)
    {
        return RankineLongConversions.RankineToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Réaumur <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this RéaumurLong input)
    {
        return RéaumurLongConversions.RéaumurToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="long" /> result.
    /// </returns>
    public static long ToRéaumur(
        this RømerLong input)
    {
        return RømerLongConversions.RømerToRéaumur(input.Temperature);
    }
}
