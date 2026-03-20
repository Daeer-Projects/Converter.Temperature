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
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="int" /> result.
    /// </returns>
    public static int ToDelisle(
        this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="int" /> result.
    /// </returns>
    public static int ToDelisle(
        this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Delisle <see langword="int" /> result.
    /// </returns>
    public static int ToDelisle(
        this GasInt input)
    {
        return GasIntConversions.GasToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="int" /> result.
    /// </returns>
    public static int ToDelisle(
        this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="int" /> result.
    /// </returns>
    public static int ToDelisle(
        this RankineInt input)
    {
        return RankineIntConversions.RankineToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="int" /> result.
    /// </returns>
    public static int ToDelisle(
        this RømerInt input)
    {
        return RømerIntConversions.RømerToDelisle(input.Temperature);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Delisle <see langword="int" /> result.
    /// </returns>
    public static int ToDelisle(
        this DelisleInt input)
    {
        return DelisleIntConversions.DelisleToDelisle(input.Temperature);
    }
}
