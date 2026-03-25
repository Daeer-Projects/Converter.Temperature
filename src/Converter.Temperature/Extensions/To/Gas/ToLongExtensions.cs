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

namespace Converter.Temperature.Extensions.To.Gas;

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

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="int" /> result.
    /// </returns>
    public static long ToGas(
        this RømerLong input)
    {
        return RømerLongConversions.RømerToGas(input.Temperature);
    }
}
