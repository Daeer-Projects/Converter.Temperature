﻿namespace Converter.Temperature.Converters.Gas;

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
        double celTemp;
        if (input < .25 || input > 10) throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);

        if (input < 1)
            celTemp = 125;
        else if (input < 1.5)
            celTemp = 140;
        else if (input < 2.5)
            celTemp = 150;
        else if (input < 3.5)
            celTemp = 165;
        else if (input < 4.5)
            celTemp = 180;
        else if (input < 5.5)
            celTemp = 190;
        else if (input < 6.5)
            celTemp = 200;
        else if (input < 7.5)
            celTemp = 220;
        else if (input < 8.5)
            celTemp = 230;
        else if (input < 9.5)
            celTemp = 240;
        else
            celTemp = 260;

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
        if (input < .25 || input > 10) throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);

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