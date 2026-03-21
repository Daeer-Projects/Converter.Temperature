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
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this DelisleInt input)
    {
        return DelisleIntConversions.DelisleToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this GasInt input)
    {
        return GasIntConversions.GasToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Newton <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this NewtonInt input)
    {
        return NewtonIntConversions.NewtonToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this RankineInt input)
    {
        return RankineIntConversions.RankineToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Réaumur <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this RéaumurInt input)
    {
        return RéaumurIntConversions.RéaumurToRéaumur(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Réaumur
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Réaumur <see langword="int" /> result.
    /// </returns>
    public static int ToRéaumur(
        this RømerInt input)
    {
        return RømerIntConversions.RømerToRéaumur(input.Temperature);
    }
}
