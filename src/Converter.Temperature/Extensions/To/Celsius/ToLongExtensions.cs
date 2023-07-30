namespace Converter.Temperature.Extensions.To.Celsius;

using System;
using Converter.Temperature.Converters.Rømer;
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
using Types.Rømer;

/// <summary>
///     The to <see langword="long" /> extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Celsius <see langword="long" /> result.
    /// </returns>
    public static long ToCelsius(
        this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="long" /> result.
    /// </returns>
    public static long ToCelsius(
        this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Celsius <see langword="long" /> result.
    /// </returns>
    public static long ToCelsius(
        this GasLong input)
    {
        return GasLongConversions.GasToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="long" /> result.
    /// </returns>
    public static long ToCelsius(
        this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="long" /> result.
    /// </returns>
    public static long ToCelsius(
        this RankineLong input)
    {
        return RankineLongConversions.RankineToCelsius(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Celsius <see langword="long" /> result.
    /// </returns>
    public static long ToCelsius(this RømerLong input)
    {
        return RømerLongConversions.RømerToCelsius(input.Temperature);
    }
}
