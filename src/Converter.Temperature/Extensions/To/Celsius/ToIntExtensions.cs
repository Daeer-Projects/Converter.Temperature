namespace Converter.Temperature.Extensions.To.Celsius;

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
    ///     Converts the Celsius <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Celsius <see langword="int" /> result.
    /// </returns>
    public static int ToCelsius(
        this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="int" /> result.
    /// </returns>
    public static int ToCelsius(
        this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Celsius <see langword="int" /> result.
    /// </returns>
    public static int ToCelsius(
        this GasInt input)
    {
        return GasIntConversions.GasToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="int" /> result.
    /// </returns>
    public static int ToCelsius(
        this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="int" /> result.
    /// </returns>
    public static int ToCelsius(
        this RankineInt input)
    {
        return RankineIntConversions.RankineToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="int" /> result.
    /// </returns>
    public static int ToCelsius(
        this RømerInt input)
    {
        return RømerIntConversions.RømerToCelsius(input.Temperature);
    }
}
