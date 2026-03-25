using System;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To.Rømer;

/// <summary>
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(this CelsiusInt input)
    {
        return CelsiusIntConversions.CelsiusToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(this FahrenheitInt input)
    {
        return FahrenheitIntConversions.FahrenheitToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(this GasInt input)
    {
        return GasIntConversions.GasToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(this KelvinInt input)
    {
        return KelvinIntConversions.KelvinToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(this RankineInt input)
    {
        return RankineIntConversions.RankineToRømer(input.Temperature);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rømer
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The Rømer <see langword="int" /> result.
    /// </returns>
    public static int ToRømer(this RømerInt input)
    {
        return RømerIntConversions.RømerToRømer(input.Temperature);
    }
}
