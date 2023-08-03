namespace Converter.Temperature.Extensions.To.Fahrenheit;

using System;
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
    public static int ToFahrenheit(this CelsiusInt input)
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
    public static int ToFahrenheit(this FahrenheitInt input)
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
    public static int ToFahrenheit(this GasInt input)
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
    public static int ToFahrenheit(this KelvinInt input)
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
    public static int ToFahrenheit(this RankineInt input)
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
    public static int ToFahrenheit(this RømerInt input)
    {
        return RømerIntConversions.RømerToFahrenheit(input.Temperature);
    }
}