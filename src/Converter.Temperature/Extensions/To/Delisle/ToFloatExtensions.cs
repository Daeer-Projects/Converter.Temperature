namespace Converter.Temperature.Extensions.To.Delisle;

using System;
using Converters.Celsius;
using Converters.Delisle;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using Helpers;
using Types.Celsius;
using Types.Delisle;
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
    ///     Converts the Celsius <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="float" /> result.
    /// </returns>
    public static float ToDelisle(
        this CelsiusFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            CelsiusFloatConversions.CelsiusToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="float" /> result.
    /// </returns>
    public static float ToDelisle(
        this FahrenheitFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            FahrenheitFloatConversions.FahrenheitToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Delisle <see langword="float" /> result.
    /// </returns>
    public static float ToDelisle(
        this GasFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            GasFloatConversions.GasToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="float" /> result.
    /// </returns>
    public static float ToDelisle(
        this KelvinFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            KelvinFloatConversions.KelvinToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="float" /> result.
    /// </returns>
    public static float ToDelisle(
        this RankineFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RankineFloatConversions.RankineToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Delisle <see langword="float" /> result.
    /// </returns>
    public static float ToDelisle(
        this RømerFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RømerFloatConversions.RømerToDelisle(input.Temperature),
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Delisle
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <returns>
    ///     The Delisle <see langword="float" /> result.
    /// </returns>
    public static float ToDelisle(
        this DelisleFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            DelisleFloatConversions.DelisleToDelisle(input.Temperature),
            fractionalCount);
    }
}
