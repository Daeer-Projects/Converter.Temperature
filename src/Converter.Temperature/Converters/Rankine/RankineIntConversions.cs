using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Rankine;

internal static class RankineIntConversions
{
    /// <summary>
    ///     The rankine to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToRankine(
        int input)
    {
        return input;
    }

    /// <summary>
    ///     The rankine to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToCelsius(
        int input)
    {
        double result = (input - 491.67d) * 5 / 9;
        int celsiusTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return celsiusTemp;
    }

    /// <summary>
    ///     The rankine to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToFahrenheit(
        int input)
    {
        double result = input - 459.67d;
        int fahrenheitTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The rankine to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToKelvin(
        int input)
    {
        double result = input * 5d / 9d;
        int kelvinTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return kelvinTemp;
    }

    /// <summary>
    ///     The rankine to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToGas(
        int input)
    {
        int celsiusTemp = RankineToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The rankine to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToRømer(
        int input)
    {
        double result = (input - 491.67) * 7 / 24 + 7.5;
        int rømerTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }

    /// <summary>
    ///     The rankine to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToDelisle(
        int input)
    {
        double result = (671.67 - input) * 5 / 6;
        int delisleTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return delisleTemp;
    }

    /// <summary>
    ///     The rankine to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToNewton(
        int input)
    {
        double result = (input - 491.67) * 11 / 60;
        int newtonTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return newtonTemp;
    }

    /// <summary>
    ///     The rankine to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RankineToRéaumur(
        int input)
    {
        double result = (input - 491.67) * 4 / 9;
        int réaumurTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return réaumurTemp;
    }
}

