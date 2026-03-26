using System;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Delisle;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Newton;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Réaumur;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.Extensions.To.Helpers;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Delisle;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Newton;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Réaumur;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Newton;

/// <summary>
///     The to string extensions.
/// </summary>
public static class ToStringExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this CelsiusString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, CelsiusDoubleConversions.CelsiusToNewton, fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this FahrenheitString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(
            input.Temperature,
            FahrenheitDoubleConversions.FahrenheitToNewton,
            fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this GasString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, GasDoubleConversion.GasToNewton, fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this KelvinString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, KelvinDoubleConversions.KelvinToNewton, fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this RankineString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, RankineDoubleConversions.RankineToNewton, fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this RømerString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, RømerDoubleConversions.RømerToNewton, fractionalCount);
    }

    /// <summary>
    ///     Converts the Newton <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this NewtonString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, NewtonDoubleConversions.NewtonToNewton, fractionalCount);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this DelisleString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, DelisleDoubleConversions.DelisleToNewton, fractionalCount);
    }

    /// <summary>
    ///     Converts the Réaumur <paramref name="input" /> to Newton
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Newton string result.
    /// </returns>
    public static string ToNewton(
        this RéaumurString input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Parser(input.Temperature, RéaumurDoubleConversions.RéaumurToNewton, fractionalCount);
    }
}
