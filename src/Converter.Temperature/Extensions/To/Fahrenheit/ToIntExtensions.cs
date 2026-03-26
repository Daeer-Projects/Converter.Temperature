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
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Delisle;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Newton;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Réaumur;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Fahrenheit;

/// <summary>
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this GasInt input)
    {
        return GasIntConversions.GasToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this RankineInt input)
    {
        return RankineIntConversions.RankineToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this RømerInt input)
    {
        return RømerIntConversions.RømerToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Newton <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this NewtonInt input)
    {
        return NewtonIntConversions.NewtonToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this DelisleInt input)
    {
        return DelisleIntConversions.DelisleToFahrenheit(input.Temperature);
    }

    /// <summary>
    ///     Converts the Réaumur <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="int" /> result.
    /// </returns>
    public static int ToFahrenheit(
        this RéaumurInt input)
    {
        return RéaumurIntConversions.RéaumurToFahrenheit(input.Temperature);
    }
}
