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

namespace Converter.Temperature.Extensions.To.Rømer;

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

    /// <summary>
    ///     Converts the Newton <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this NewtonLong input)
    {
        return NewtonLongConversions.NewtonToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Delisle <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this DelisleLong input)
    {
        return DelisleLongConversions.DelisleToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Réaumur <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="long" /> result.
    /// </returns>
    public static long ToRømer(this RéaumurLong input)
    {
        return RéaumurLongConversions.RéaumurToRømer(input.Temperature);
    }
}
