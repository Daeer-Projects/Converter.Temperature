namespace Converter.Temperature.Converters.Rankine;

using System;
using Celsius;

internal static class RankineLongConversions
{
    /// <summary>
    ///     The rankine to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RankineToRankine(long input)
    {
        return input;
    }

    /// <summary>
    ///     The rankine to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RankineToCelsius(long input)
    {
        long rankineTemp = (input - 492L) * 5 / 9;
        return rankineTemp;
    }

    /// <summary>
    ///     The rankine to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RankineToFahrenheit(long input)
    {
        long rankineTemp = input - 460L;
        return rankineTemp;
    }

    /// <summary>
    ///     The rankine to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RankineToKelvin(long input)
    {
        long rankineTemp = input * 5 / 9;
        return rankineTemp;
    }

    /// <summary>
    ///     The rankine to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RankineToGas(long input)
    {
        long celsiusTemp = RankineToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The rankine to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RankineToRømer(long input)
    {
        double result = (input - 491.67) * 7 / 24 + 7.5;
        long rømerTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }
}