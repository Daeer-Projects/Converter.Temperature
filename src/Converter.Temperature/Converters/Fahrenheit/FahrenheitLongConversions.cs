﻿namespace Converter.Temperature.Converters.Fahrenheit;

using System;
using Celsius;

internal static class FahrenheitLongConversions
{
    /// <summary>
    ///     The fahrenheit to celsius conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToCelsius(
        long firstTemp)
    {
        double celsiusTemp = (firstTemp - 32d) * 5 / 9;
        long celsiusTempLong = (long)Math.Round(celsiusTemp, 0, MidpointRounding.AwayFromZero);
        return celsiusTempLong;
    }

    /// <summary>
    ///     The fahrenheit to fahrenheit conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToFahrenheit(
        long firstTemp)
    {
        return firstTemp;
    }

    /// <summary>
    ///     The fahrenheit to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToKelvin(
        long input)
    {
        double calculatedValue = (input - 32d) * 5 / 9 + 273.15d;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        long kelvinTemp = (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);

        return kelvinTemp;
    }

    /// <summary>
    ///     The fahrenheit to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToGas(
        long input)
    {
        long celsiusTemp = FahrenheitToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The fahrenheit to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRankine(
        long input)
    {
        const long maxValue = long.MaxValue - 460;
        const long minValue = long.MinValue + 460;
        if (input is < minValue or > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        long rankineTemp = input + 460;
        return rankineTemp;
    }

    /// <summary>
    ///     The fahrenheit to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRømer(
        long input)
    {
        double result = (input - 32f) * 7 / 24 + 7.5f;
        long rømerTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }
}
