namespace Converter.Temperature.Converters.Gas;

using System;
using Celsius;

internal static class GasIntConversions
{
    /// <summary>
    ///     The gas to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static int GasToCelsius(int input)
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
    ///     The gas to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static int GasToFahrenheit(int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int fahrenheitTemp = CelsiusIntConversions.CelsiusToFahrenheit(celsiusTemp);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The gas to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static int GasToKelvin(int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int kelvinTemp = CelsiusIntConversions.CelsiusToKelvin(celsiusTemp);
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
    public static int GasToGas(int input)
    {
        if (input < 1 || input > 10) throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);

        return input;
    }

    /// <summary>
    ///     The gas to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static int GasToRankine(int input)
    {
        int celsiusTemp = GasToCelsius(input);
        int rankineTemp = CelsiusIntConversions.CelsiusToRankine(celsiusTemp);
        return rankineTemp;
    }
}