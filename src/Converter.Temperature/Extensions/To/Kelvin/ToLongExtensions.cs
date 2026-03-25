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

namespace Converter.Temperature.Extensions.To.Kelvin;

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
    public static long ToKelvin(
        this CelsiusLong input)
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
    public static long ToKelvin(
        this FahrenheitLong input)
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
    public static long ToKelvin(
        this GasLong input)
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
    public static long ToKelvin(
        this KelvinLong input)
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
    public static long ToKelvin(
        this RankineLong input)
    {
        return RankineLongConversions.RankineToKelvin(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Kelvin <see langword="long" /> result.
    /// </returns>
    public static long ToKelvin(
        this RømerLong input)
    {
        return RømerLongConversions.RømerToKelvin(input.Temperature);
    }
}
