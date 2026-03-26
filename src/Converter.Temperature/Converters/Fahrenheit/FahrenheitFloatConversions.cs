using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Fahrenheit;

internal static class FahrenheitFloatConversions
{
    /// <summary>
    ///     The Fahrenheit to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float FahrenheitToCelsius(
        float input)
    {
        float celsiusTemp = (input - 32) * 5 / 9;
        if (float.IsPositiveInfinity(celsiusTemp) || float.IsNegativeInfinity(celsiusTemp))
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
    internal static float FahrenheitToFahrenheit(
        float input)
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
    internal static float FahrenheitToKelvin(
        float input)
    {
        float kelvinTemp = (input + 459.67f) * 5f / 9f;
        if (float.IsPositiveInfinity(kelvinTemp) || float.IsNegativeInfinity(kelvinTemp))
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
    internal static float FahrenheitToGas(
        float input)
    {
        float celsiusTemp = FahrenheitToCelsius(input);
        float gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusTemp);
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
    internal static float FahrenheitToRankine(
        float input)
    {
        float rankineTemp = input + 459.67f;
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
    internal static float FahrenheitToRømer(
        float input)
    {
        float rømerTemp = (input - 32f) * 7 / 24 + 7.5f;
        if (float.IsPositiveInfinity(rømerTemp) || float.IsNegativeInfinity(rømerTemp))
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
    internal static float FahrenheitToDelisle(
        float input)
    {
        float delisleTemp = (212f - input) * 5 / 6;
        if (float.IsPositiveInfinity(delisleTemp) || float.IsNegativeInfinity(delisleTemp))
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
    internal static float FahrenheitToNewton(
        float input)
    {
        float newtonTemp = (input - 32) * 11 / 60;
        if (float.IsPositiveInfinity(newtonTemp) || float.IsNegativeInfinity(newtonTemp))
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
    internal static float FahrenheitToRéaumur(
        float input)
    {
        float réaumurTemp = (input - 32) * 4 / 9;
        if (float.IsPositiveInfinity(réaumurTemp) || float.IsNegativeInfinity(réaumurTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurTemp;
    }
}

