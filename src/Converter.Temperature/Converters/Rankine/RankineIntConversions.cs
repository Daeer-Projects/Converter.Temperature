namespace Converter.Temperature.Converters.Rankine;

using System;
using Celsius;

internal static class RankineIntConversions
{
    /// <summary>
    ///     The rankine to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToRankine(int input)
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
    internal static int RankineToCelsius(int input)
    {
        int rankineTemp = (input - 492) * 5 / 9;
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
    internal static int RankineToFahrenheit(int input)
    {
        int rankineTemp = input - 460;
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
    internal static int RankineToKelvin(int input)
    {
        int rankineTemp = input * 5 / 9;
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
    internal static int RankineToGas(int input)
    {
        int celsiusTemp = RankineToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
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
    internal static int RankineToRømer(int input)
    {
        double result = (input - 491.67) * 7 / 24 + 7.5;
        int rømerTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }
}