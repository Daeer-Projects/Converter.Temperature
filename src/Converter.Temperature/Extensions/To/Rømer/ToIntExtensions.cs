namespace Converter.Temperature.Extensions.To.Rømer;

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
    ///     Converts the Celsius <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(
        this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(
        this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(
        this GasInt input)
    {
        return GasIntConversions.GasToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(
        this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(
        this RankineInt input)
    {
        return RankineIntConversions.RankineToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(
        this RømerInt input)
    {
        return RømerIntConversions.RømerToRømer(input.Temperature);
    }
}
