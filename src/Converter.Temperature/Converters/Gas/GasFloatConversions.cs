namespace Converter.Temperature.Converters.Gas;

using System;
using Celsius;

internal static class GasFloatConversions
{
    /// <summary>
    ///     The gas to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
    ///     The gas to fahrenheit conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToFahrenheit(
        float firstTemp)
    {
        float celsiusTemp = GasToCelsius(firstTemp);
        float fahrenheitTemp = CelsiusFloatConversions.CelsiusToFahrenheit(celsiusTemp);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The gas to kelvin conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToKelvin(
        float firstTemp)
    {
        float celsiusTemp = GasToCelsius(firstTemp);
        float kelvinTemp = CelsiusFloatConversions.CelsiusToKelvin(celsiusTemp);
        return kelvinTemp;
    }

    /// <summary>
    ///     The gas to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
    ///     The gas to rankine conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float GasToRankine(
        float firstTemp)
    {
        float celsiusTemp = GasToCelsius(firstTemp);
        float rankineTemp = CelsiusFloatConversions.CelsiusToRankine(celsiusTemp);
        return rankineTemp;
    }

    /// <summary>
    ///     The gas to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
}
