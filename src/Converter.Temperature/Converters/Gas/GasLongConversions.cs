using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Gas;

internal static class GasLongConversions
{
    /// <summary>
    ///     The gas to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToCelsius(
        long input)
    {
        long celTemp = input switch
        {
            1 => 150,
            2 => 165,
            3 => 180,
            4 => 190,
            5 => 202,
            6 => 217,
            7 => 230,
            8 => 240,
            9 => 250,
            10 => 265,
            _ => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError)
        };

        return celTemp;
    }

    /// <summary>
    ///     The gas to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToFahrenheit(
        long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long fahrenheitTemp = CelsiusLongConversions.CelsiusToFahrenheit(celsiusTemp);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The gas to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToKelvin(
        long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long kelvinTemp = CelsiusLongConversions.CelsiusToKelvin(celsiusTemp);
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
    internal static long GasToGas(
        long input)
    {
        if (input is < 1 or > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);
        }

        return input;
    }

    /// <summary>
    ///     The gas to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToRankine(
        long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long rankineTemp = CelsiusLongConversions.CelsiusToRankine(celsiusTemp);
        return rankineTemp;
    }

    /// <summary>
    ///     The gas to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToRømer(
        long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long rømerTemp = CelsiusLongConversions.CelsiusToRømer(celsiusTemp);
        return rømerTemp;
    }

    /// <summary>
    ///     The gas to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToDelisle(
        long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long delisleTemp = CelsiusLongConversions.CelsiusToDelisle(celsiusTemp);
        return delisleTemp;
    }

    /// <summary>
    ///     The gas to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToNewton(
        long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long newtonTemp = CelsiusLongConversions.CelsiusToNewton(celsiusTemp);
        return newtonTemp;
    }

    /// <summary>
    ///     The gas to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long GasToRéaumur(
        long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long réaumurTemp = CelsiusLongConversions.CelsiusToRéaumur(celsiusTemp);
        return réaumurTemp;
    }
}
