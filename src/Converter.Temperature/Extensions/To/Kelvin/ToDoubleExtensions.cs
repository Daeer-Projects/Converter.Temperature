namespace Converter.Temperature.Extensions.To.Kelvin;

using System;
using Helpers;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(CelsiusDoubleConversions.CelsiusToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(FahrenheitDoubleConversions.FahrenheitToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(GasDoubleConversion.GasToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(KelvinDoubleConversions.KelvinToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RankineDoubleConversions.RankineToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RømerDoubleConversions.RømerToKelvin(input.Temperature), fractionalCount);
    }
}