namespace Converter.Temperature.Extensions.To.Rømer;

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

public static class ToStringExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer string result.
    /// </returns>
    public static string ToRømer(
        this CelsiusString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, CelsiusDoubleConversions.CelsiusToRømer, fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer string result.
    /// </returns>
    public static string ToRømer(
        this FahrenheitString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, FahrenheitDoubleConversions.FahrenheitToRømer,
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
    ///     The Rømer string result.
    /// </returns>
    public static string ToRømer(
        this GasString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, GasDoubleConversion.GasToRømer, fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer string result.
    /// </returns>
    public static string ToRømer(
        this KelvinString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, KelvinDoubleConversions.KelvinToRømer, fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer string result.
    /// </returns>
    public static string ToRømer(
        this RankineString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, RankineDoubleConversions.RankineToRømer, fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rømer string result.
    /// </returns>
    public static string ToRømer(
        this RømerString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, RømerDoubleConversions.RømerToRømer, fractionalCount);
    }
}
