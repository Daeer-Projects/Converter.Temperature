namespace Converter.Temperature.Extensions.To.Fahrenheit;

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
    ///     Converts the Celsius <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The CelsiusDoubleConversions <see langword="long" /> result.
    /// </returns>
    public static long ToFahrenheit(
        this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Fahrenheit <see langword="long" /> result.
    /// </returns>
    public static long ToFahrenheit(
        this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="long" /> result.
    /// </returns>
    public static long ToFahrenheit(
        this GasLong input)
    {
        return GasLongConversions.GasToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="long" /> result.
    /// </returns>
    public static long ToFahrenheit(
        this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="long" /> result.
    /// </returns>
    public static long ToFahrenheit(
        this RankineLong input)
    {
        return RankineLongConversions.RankineToFahrenheit(input.Temperature);
    }
}
