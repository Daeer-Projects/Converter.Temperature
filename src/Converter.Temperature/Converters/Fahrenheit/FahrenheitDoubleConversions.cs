using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Fahrenheit;

internal static class FahrenheitDoubleConversions
{
    /// <summary>
    ///     The Fahrenheit to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToCelsius(
        double input)
    {
        double celsiusTemp = (input - 32) * 5 / 9;
        if (double.IsPositiveInfinity(celsiusTemp) || double.IsNegativeInfinity(celsiusTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return celsiusTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToFahrenheit(
        double input)
    {
        return input;
    }

    /// <summary>
    ///     The Fahrenheit to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToKelvin(
        double input)
    {
        double kelvinTemp = (input + 459.67d) * 5d / 9d;
        if (double.IsPositiveInfinity(kelvinTemp) || double.IsNegativeInfinity(kelvinTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return kelvinTemp;
    }

    /// <summary>
    ///     The Fahrenheit to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToGas(
        double input)
    {
        double celsiusTemp = FahrenheitToCelsius(input);
        double gasTemp = CelsiusDoubleConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToRankine(
        double input)
    {
        double rankineTemp = input + 459.67d;
        return rankineTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToRømer(
        double input)
    {
        double rømerTemp = (input - 32) * 7 / 24 + 7.5;
        if (double.IsPositiveInfinity(rømerTemp) || double.IsNegativeInfinity(rømerTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToDelisle(
        double input)
    {
        double delisleTemp = (212d - input) * 5 / 6;
        if (double.IsPositiveInfinity(delisleTemp) || double.IsNegativeInfinity(delisleTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return delisleTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToNewton(
        double input)
    {
        double newtonTemp = (input - 32) * 11 / 60;
        if (double.IsPositiveInfinity(newtonTemp) || double.IsNegativeInfinity(newtonTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return newtonTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToRéaumur(
        double input)
    {
        double réaumurTemp = (input - 32) * 4 / 9;
        if (double.IsPositiveInfinity(réaumurTemp) || double.IsNegativeInfinity(réaumurTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurTemp;
    }
}

