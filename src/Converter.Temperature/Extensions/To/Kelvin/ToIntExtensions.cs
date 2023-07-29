namespace Converter.Temperature.Extensions.To.Kelvin;

using System;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;

/// <summary>
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Kelvin <see langword="int" /> result.
    /// </returns>
    public static int ToKelvin(this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Kelvin <see langword="int" /> result.
    /// </returns>
    public static int ToKelvin(this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Kelvin <see langword="int" /> result.
    /// </returns>
    public static int ToKelvin(this GasInt input)
    {
        return GasIntConversions.GasToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Kelvin <see langword="int" /> result.
    /// </returns>
    public static int ToKelvin(this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Kelvin <see langword="int" /> result.
    /// </returns>
    public static int ToKelvin(this RankineInt input)
    {
        return RankineIntConversions.RankineToKelvin(input.Temperature);
    }
}