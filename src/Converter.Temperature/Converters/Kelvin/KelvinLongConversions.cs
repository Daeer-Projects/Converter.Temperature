using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Kelvin;

internal static class KelvinLongConversions
{
    /// <summary>
    ///     The kelvin to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToCelsius(
        long input)
    {
        double result = input - 273.15d;
        long celsiusTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return celsiusTemp;
    }

    /// <summary>
    ///     The kelvin to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToFahrenheit(
        long input)
    {
        double result = input * 9d / 5d - 459.67d;
        long fahrenheitTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The kelvin to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToKelvin(
        long input)
    {
        return input;
    }

    /// <summary>
    ///     The kelvin to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToGas(
        long input)
    {
        long celsiusTemp = KelvinToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The kelvin to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToRankine(
        long input)
    {
        long rankineTemp = input * 9 / 5;
        return rankineTemp;
    }

    /// <summary>
    ///     The kelvin to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToRømer(
        long input)
    {
        double result = (input - 273.15) * 21 / 40 + 7.5;
        long rømerTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }

    /// <summary>
    ///     The kelvin to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToDelisle(
        long input)
    {
        double result = (373.15 - input) * 1.5;
        long delisleTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return delisleTemp;
    }

    /// <summary>
    ///     The kelvin to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToNewton(
        long input)
    {
        double result = (input - 273.15) * 33 / 100;
        long newtonTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return newtonTemp;
    }

    /// <summary>
    ///     The kelvin to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToRéaumur(
        long input)
    {
        double result = (input - 273.15) * 4 / 5;
        long réaumurTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return réaumurTemp;
    }
}

