using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Gas;

internal static class GasIntConversions
{
    /// <summary>
    ///     The gas to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int GasToCelsius(
        int input)
    {
        int celTemp = input switch
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
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int GasToFahrenheit(
        int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int fahrenheitTemp = CelsiusIntConversions.CelsiusToFahrenheit(celsiusTemp);
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
    internal static int GasToKelvin(
        int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int kelvinTemp = CelsiusIntConversions.CelsiusToKelvin(celsiusTemp);
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
    internal static int GasToGas(
        int input)
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
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int GasToRankine(
        int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int rankineTemp = CelsiusIntConversions.CelsiusToRankine(celsiusTemp);
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
    internal static int GasToRømer(
        int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int rømerTemp = CelsiusIntConversions.CelsiusToRømer(celsiusTemp);
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
    internal static int GasToDelisle(
        int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int delisleTemp = CelsiusIntConversions.CelsiusToDelisle(celsiusTemp);
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
    internal static int GasToNewton(
        int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int newtonTemp = CelsiusIntConversions.CelsiusToNewton(celsiusTemp);
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
    internal static int GasToRéaumur(
        int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int réaumurTemp = CelsiusIntConversions.CelsiusToRéaumur(celsiusTemp);
        return réaumurTemp;
    }
}

