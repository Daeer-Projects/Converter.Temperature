﻿namespace Converter.Temperature.Extensions.To.Fahrenheit;

using System;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using Helpers;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="float" /> extensions.
/// </summary>
public static class ToFloatExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="float" /> result.
    /// </returns>
    public static float ToFahrenheit(
        this CelsiusFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            CelsiusFloatConversions.CelsiusToFahrenheit(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <returns>
    ///     The Fahrenheit <see langword="float" /> result.
    /// </returns>
    public static float ToFahrenheit(
        this FahrenheitFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            FahrenheitFloatConversions.FahrenheitToFahrenheit(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="float" /> result.
    /// </returns>
    public static float ToFahrenheit(
        this GasFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(GasFloatConversions.GasToFahrenheit(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="float" /> result.
    /// </returns>
    public static float ToFahrenheit(
        this KelvinFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            KelvinFloatConversions.KelvinToFahrenheit(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="float" /> result.
    /// </returns>
    public static float ToFahrenheit(
        this RankineFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RankineFloatConversions.RankineToFahrenheit(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="float" /> result.
    /// </returns>
    public static float ToFahrenheit(
        this RømerFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(RømerFloatConversions.RømerToFahrenheit(input.Temperature), fractionalCount);
    }
}
