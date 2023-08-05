namespace Converter.Temperature.Extensions.To.Gas;

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
    ///     Converts the Celsius <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="long" /> result.
    /// </returns>
    public static long ToGas(
        this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="long" /> result.
    /// </returns>
    public static long ToGas(
        this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="long" /> result.
    /// </returns>
    public static long ToGas(
        this GasLong input)
    {
        return GasLongConversions.GasToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="long" /> result.
    /// </returns>
    public static long ToGas(
        this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="long" /> result.
    /// </returns>
    public static long ToGas(
        this RankineLong input)
    {
        return RankineLongConversions.RankineToGas(input.Temperature);
    }
}
