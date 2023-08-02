namespace Converter.Temperature.Converters.Fahrenheit;

using System;
using Celsius;

internal static class FahrenheitDoubleConversions
{
    /// <summary>
    ///     The fahrenheit to celsius conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToCelsius(double firstTemp)
    {
        double celsiusTemp = (firstTemp - 32) * 5 / 9;
        if (double.IsPositiveInfinity(celsiusTemp) || double.IsNegativeInfinity(celsiusTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(firstTemp), Constants.ValueOutOfRangeForType);
        }

        return celsiusTemp;
    }

    /// <summary>
    ///     The fahrenheit to fahrenheit conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToFahrenheit(double firstTemp)
    {
        return firstTemp;
    }

    /// <summary>
    ///     The fahrenheit to kelvin conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToKelvin(double firstTemp)
    {
        double celsiusTemp = FahrenheitToCelsius(firstTemp);
        double kelvinTemp = CelsiusDoubleConversions.CelsiusToKelvin(celsiusTemp);
        return kelvinTemp;
    }

    /// <summary>
    ///     The fahrenheit to gas conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToGas(double firstTemp)
    {
        double celsiusTemp = FahrenheitToCelsius(firstTemp);
        double gasTemp = CelsiusDoubleConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The fahrenheit to rankine conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double FahrenheitToRankine(double firstTemp)
    {
        double rankineTemp = firstTemp + 459.67d;
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
    internal static double FahrenheitToRømer(double input)
    {
        double rømerTemp = (input - 491.67) * 7 / 24 + 7.5;
        if (double.IsPositiveInfinity(rømerTemp) || double.IsNegativeInfinity(rømerTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerTemp;
    }
}