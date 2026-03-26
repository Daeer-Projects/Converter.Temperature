using System;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.Extensions.To.Helpers;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Rømer;

/// <summary>
///     The to <see langword="float" /> extensions.
/// </summary>
public static class ToFloatExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="float" /> result.
    /// </returns>
    public static float ToRømer(
        this CelsiusFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(CelsiusFloatConversions.CelsiusToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="float" /> result.
    /// </returns>
    public static float ToRømer(
        this FahrenheitFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            FahrenheitFloatConversions.FahrenheitToRømer(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="float" /> result.
    /// </returns>
    public static float ToRømer(
        this GasFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(GasFloatConversions.GasToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="float" /> result.
    /// </returns>
    public static float ToRømer(
        this KelvinFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(KelvinFloatConversions.KelvinToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="float" /> result.
    /// </returns>
    public static float ToRømer(
        this RankineFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RankineFloatConversions.RankineToRømer(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer <see langword="float" /> result.
    /// </returns>
    public static float ToRømer(
        this RømerFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RømerFloatConversions.RømerToRømer(input.Temperature), fractionalCount);
    }
}
