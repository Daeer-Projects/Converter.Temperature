namespace Converter.Temperature.Converters.Gas;

using System;
using Celsius;

internal static class GasLongConversions
{
    /// <summary>
    ///     The gas to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static long GasToCelsius(long input)
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
    ///     The gas to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static long GasToFahrenheit(long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long fahrenheitTemp = CelsiusLongConversions.CelsiusToFahrenheit(celsiusTemp);
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
    public static long GasToKelvin(long input)
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
    public static long GasToGas(long input)
    {
        if (input is < 1 or > 10) throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);

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
    public static long GasToRankine(long input)
    {
        long celsiusTemp = GasToCelsius(input);
        long rankineTemp = CelsiusLongConversions.CelsiusToRankine(celsiusTemp);
        return rankineTemp;
    }
}