namespace Converter.Temperature.Converters.Gas;

using System;
using Celsius;

internal static class GasDoubleConversion
{
    /// <summary>
    ///     The gas to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double GasToCelsius(
        double input)
    {
        double celTemp = input switch
        {
            < .25 => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError),
            > 10 => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError),
            < 1 => 125,
            < 1.5 => 140,
            < 2.5 => 150,
            < 3.5 => 165,
            < 4.5 => 180,
            < 5.5 => 190,
            < 6.5 => 200,
            < 7.5 => 220,
            < 8.5 => 230,
            < 9.5 => 240,
            _ => 260
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
    internal static double GasToFahrenheit(
        double input)
    {
        double celsiusTemp = GasToCelsius(input);
        double fahrenheitTemp = CelsiusDoubleConversions.CelsiusToFahrenheit(celsiusTemp);
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
    internal static double GasToKelvin(
        double input)
    {
        double celsiusTemp = GasToCelsius(input);
        double kelvinTemp = CelsiusDoubleConversions.CelsiusToKelvin(celsiusTemp);
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
    internal static double GasToGas(
        double input)
    {
        if (input is < .25 or > 10)
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
    internal static double GasToRankine(
        double input)
    {
        double celsiusTemp = GasToCelsius(input);
        double rankineTemp = CelsiusDoubleConversions.CelsiusToRankine(celsiusTemp);
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
    internal static double GasToRømer(
        double input)
    {
        double celsiusTemp = GasToCelsius(input);
        double rømerTemp = CelsiusDoubleConversions.CelsiusToRømer(celsiusTemp);
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
    internal static double GasToDelisle(
        double input)
    {
        double celsiusTemp = GasToCelsius(input);
        double delisleTemp = CelsiusDoubleConversions.CelsiusToDelisle(celsiusTemp);
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
    internal static double GasToNewton(
        double input)
    {
        double celsiusTemp = GasToCelsius(input);
        double newtonTemp = CelsiusDoubleConversions.CelsiusToNewton(celsiusTemp);
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
    internal static double GasToRéaumur(
        double input)
    {
        double celsiusTemp = GasToCelsius(input);
        double réaumurTemp = CelsiusDoubleConversions.CelsiusToRéaumur(celsiusTemp);
        return réaumurTemp;
    }
}
