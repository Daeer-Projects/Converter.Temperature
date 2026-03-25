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

namespace Converter.Temperature.Extensions.To.Fahrenheit;

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

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="long" /> result.
    /// </returns>
    public static long ToFahrenheit(
        this RømerLong input)
    {
        return RømerLongConversions.RømerToFahrenheit(input.Temperature);
    }
}
