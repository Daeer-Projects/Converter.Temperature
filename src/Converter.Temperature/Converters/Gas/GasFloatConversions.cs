using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Gas;

internal static class GasFloatConversions
{
    /// <summary>
    ///     The gas to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToCelsius(
        float input)
    {
        float celTemp = input switch
        {
            < .25f => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError),
            > 10f => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError),
            < 1f => 125,
            < 1.5f => 140,
            < 2.5f => 150,
            < 3.5f => 165,
            < 4.5f => 180,
            < 5.5f => 190,
            < 6.5f => 200,
            < 7.5f => 220,
            < 8.5f => 230,
            < 9.5f => 240,
            _ => 260
        };

        return celTemp;
    }

    /// <summary>
    ///     The gas to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToFahrenheit(
        float input)
    {
        float celsiusTemp = GasToCelsius(input);
        float fahrenheitTemp = CelsiusFloatConversions.CelsiusToFahrenheit(celsiusTemp);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The gas to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToKelvin(
        float input)
    {
        float celsiusTemp = GasToCelsius(input);
        float kelvinTemp = CelsiusFloatConversions.CelsiusToKelvin(celsiusTemp);
        return kelvinTemp;
    }

    /// <summary>
    ///     The gas to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToGas(
        float input)
    {
        if (input < .25 || input > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);
        }

        return input;
    }

    /// <summary>
    ///     The gas to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToRankine(
        float input)
    {
        float celsiusTemp = GasToCelsius(input);
        float rankineTemp = CelsiusFloatConversions.CelsiusToRankine(celsiusTemp);
        return rankineTemp;
    }

    /// <summary>
    ///     The gas to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToRømer(
        float input)
    {
        float celsiusTemp = GasToCelsius(input);
        float rømerTemp = CelsiusFloatConversions.CelsiusToRømer(celsiusTemp);
        return rømerTemp;
    }

    /// <summary>
    ///     The gas to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToDelisle(
        float input)
    {
        float celsiusTemp = GasToCelsius(input);
        float delisleTemp = CelsiusFloatConversions.CelsiusToDelisle(celsiusTemp);
        return delisleTemp;
    }

    /// <summary>
    ///     The gas to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToNewton(
        float input)
    {
        float celsiusTemp = GasToCelsius(input);
        float newtonTemp = CelsiusFloatConversions.CelsiusToNewton(celsiusTemp);
        return newtonTemp;
    }

    /// <summary>
    ///     The gas to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToRéaumur(
        float input)
    {
        float celsiusTemp = GasToCelsius(input);
        float réaumurTemp = CelsiusFloatConversions.CelsiusToRéaumur(celsiusTemp);
        return réaumurTemp;
    }
}

