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

namespace Converter.Temperature.Extensions.To.Réaumur;

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
