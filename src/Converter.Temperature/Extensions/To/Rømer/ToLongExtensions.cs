namespace Converter.Temperature.Extensions.To.Rømer;

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
///     The to <see langword="long" /> extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this CelsiusLong input)
    {
        return CelsiusLongConversions.CelsiusToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this FahrenheitLong input)
    {
        return FahrenheitLongConversions.FahrenheitToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this GasLong input)
    {
        return GasLongConversions.GasToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this KelvinLong input)
    {
        return KelvinLongConversions.KelvinToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this RankineLong input)
    {
        return RankineLongConversions.RankineToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this RømerLong input)
    {
        return RømerLongConversions.RømerToRømer(input.Temperature);
    }
}
