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
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="int" /> result.
    /// </returns>
    public static int ToGas(this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="int" /> result.
    /// </returns>
    public static int ToGas(this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="int" /> result.
    /// </returns>
    public static int ToGas(this GasInt input)
    {
        return GasIntConversions.GasToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="int" /> result.
    /// </returns>
    public static int ToGas(this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToGas(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Gas <see langword="int" /> result.
    /// </returns>
    public static int ToGas(this RankineInt input)
    {
        return RankineIntConversions.RankineToGas(input.Temperature);
    }
}