namespace Converter.Temperature.Converters.Gas;

using System;
using Celsius;

internal static class GasDoubleConversion
{
    /// <summary>
    ///     The gas to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static double GasToCelsius(double input)
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
    ///     The gas to fahrenheit conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static double GasToFahrenheit(double firstTemp)
    {
        double celsiusTemp = GasToCelsius(firstTemp);
        double fahrenheitTemp = CelsiusDoubleConversions.CelsiusToFahrenheit(celsiusTemp);
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
    public static double GasToKelvin(double firstTemp)
    {
        double celsiusTemp = GasToCelsius(firstTemp);
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
    public static double GasToGas(double input)
    {
        if (input is < .25 or > 10)
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
    public static double GasToRankine(double firstTemp)
    {
        double celsiusTemp = GasToCelsius(firstTemp);
        double rankineTemp = CelsiusDoubleConversions.CelsiusToRankine(celsiusTemp);
        return rankineTemp;
    }
}