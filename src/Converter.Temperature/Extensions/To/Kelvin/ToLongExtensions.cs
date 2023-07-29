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
///     The to <see langword="long" /> extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Kelvin <see langword="long" /> result.
    /// </returns>
    public static long ToKelvin(this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Kelvin <see langword="long" /> result.
    /// </returns>
    public static long ToKelvin(this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Kelvin <see langword="long" /> result.
    /// </returns>
    public static long ToKelvin(this GasLong input)
    {
        return GasLongConversions.GasToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Kelvin <see langword="long" /> result.
    /// </returns>
    public static long ToKelvin(this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Kelvin <see langword="long" /> result.
    /// </returns>
    public static long ToKelvin(this RankineLong input)
    {
        return RankineLongConversions.RankineToKelvin(input.Temperature);
    }
}