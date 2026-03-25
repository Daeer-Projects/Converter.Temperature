using System;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Celsius;

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
    public static long ToCelsius(
        this RømerLong input)
    {
        return RømerLongConversions.RømerToCelsius(input.Temperature);
    }
}
