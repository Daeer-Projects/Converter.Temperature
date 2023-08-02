namespace Converter.Temperature.Converters.Kelvin;

using System;
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
    internal static double KelvinToCelsius(double firstTemp)
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
    internal static double KelvinToFahrenheit(double firstTemp)
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
    internal static double KelvinToKelvin(double firstTemp)
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
    internal static double KelvinToGas(double firstTemp)
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
    internal static double KelvinToRankine(double firstTemp)
    {
        double rankineTemp = firstTemp * 9 / 5;
        return rankineTemp;
    }

    /// <summary>
    ///     The kelvin to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double KelvinToRømer(double input)
    {
        double rømerTemp = (input - 273.15) * 21 / 40 + 7.5;
        if (double.IsPositiveInfinity(rømerTemp) || double.IsNegativeInfinity(rømerTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerTemp;
    }
}