namespace Converter.Temperature.Extensions.To.Kelvin;

using System;
using Helpers;
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
///     The to <see langword="float" /> extensions.
/// </summary>
public static class ToFloatExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="float" /> result.
    /// </returns>
    public static float ToKelvin(
        this CelsiusFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(CelsiusFloatConversions.CelsiusToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="float" /> result.
    /// </returns>
    public static float ToKelvin(
        this FahrenheitFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(FahrenheitFloatConversions.FahrenheitToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="float" /> result.
    /// </returns>
    public static float ToKelvin(
        this GasFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(GasFloatConversions.GasToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="float" /> result.
    /// </returns>
    public static float ToKelvin(
        this KelvinFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(KelvinFloatConversions.KelvinToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="float" /> result.
    /// </returns>
    public static float ToKelvin(
        this RankineFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RankineFloatConversions.RankineToKelvin(input.Temperature), fractionalCount);
    }
}