﻿namespace Converter.Temperature.Converters.Kelvin;

using Celsius;

internal static class KelvinDoubleConversions
{
    /// <summary>
    ///     The kelvin to celsius conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static double KelvinToCelsius(
        double firstTemp)
    {
        double celsiusTemp = firstTemp - 273.15;
        return celsiusTemp;
    }

    /// <summary>
    ///     The kelvin to fahrenheit conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static double KelvinToFahrenheit(
        double firstTemp)
    {
        double celsiusTemp = KelvinToCelsius(firstTemp);
        double fahrenheitTemp = CelsiusDoubleConversions.CelsiusToFahrenheit(celsiusTemp);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The kelvin to kelvin conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static double KelvinToKelvin(
        double firstTemp)
    {
        return firstTemp;
    }

    /// <summary>
    ///     The kelvin to gas conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static double KelvinToGas(
        double firstTemp)
    {
        double celsiusTemp = KelvinToCelsius(firstTemp);
        double gasTemp = CelsiusDoubleConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The kelvin to rankine conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static double KelvinToRankine(
        double firstTemp)
    {
        double rankineTemp = firstTemp * 9 / 5;
        return rankineTemp;
    }
}
