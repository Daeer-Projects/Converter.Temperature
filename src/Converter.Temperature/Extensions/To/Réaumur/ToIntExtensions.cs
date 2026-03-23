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
