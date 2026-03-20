namespace Converter.Temperature.Extensions.To.Delisle;

using System;
using Converters.Celsius;
using Converters.Delisle;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using Types.Celsius;
using Types.Delisle;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="long" /> extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="long" /> result.
    /// </returns>
    public static long ToDelisle(
        this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="long" /> result.
    /// </returns>
    public static long ToDelisle(
        this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Delisle <see langword="long" /> result.
    /// </returns>
    public static long ToDelisle(
        this GasLong input)
    {
        return GasLongConversions.GasToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="long" /> result.
    /// </returns>
    public static long ToDelisle(
        this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="long" /> result.
    /// </returns>
    public static long ToDelisle(
        this RankineLong input)
    {
        return RankineLongConversions.RankineToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="long" /> result.
    /// </returns>
    public static long ToDelisle(
        this RømerLong input)
    {
        return RømerLongConversions.RømerToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Delisle <see langword="long" /> result.
    /// </returns>
    public static long ToDelisle(
        this DelisleLong input)
    {
        return DelisleLongConversions.DelisleToDelisle(input.Temperature);
    }
}
