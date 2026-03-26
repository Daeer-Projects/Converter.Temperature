using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Kelvin;

internal static class KelvinIntConversions
{
    /// <summary>
    ///     The kelvin to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int KelvinToCelsius(
        int input)
    {
        double result = input - 273.15d;
        int celsiusTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
    internal static int KelvinToFahrenheit(
        int input)
    {
        double result = input * 9d / 5d - 459.67d;
        int fahrenheitTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The kelvin to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int KelvinToKelvin(
        int input)
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
    internal static int KelvinToGas(
        int input)
    {
        int celsiusTemp = KelvinToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
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
    internal static int KelvinToRankine(
        int input)
    {
        int rankineTemp = input * 9 / 5;
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
    internal static int KelvinToRømer(
        int input)
    {
        double result = (input - 273.15) * 21 / 40 + 7.5;
        int rømerTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
    internal static int KelvinToDelisle(
        int input)
    {
        double result = (373.15 - input) * 1.5;
        int delisleTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
    internal static int KelvinToNewton(
        int input)
    {
        double result = (input - 273.15) * 33 / 100;
        int newtonTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
    internal static int KelvinToRéaumur(
        int input)
    {
        double result = (input - 273.15) * 4 / 5;
        int réaumurTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return réaumurTemp;
    }
}

