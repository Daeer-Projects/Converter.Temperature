namespace Converter.Temperature.Converters.Fahrenheit;

using System;
using Celsius;

internal static class FahrenheitFloatConversions
{
    /// <summary>
    ///     The fahrenheit to celsius conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static float FahrenheitToCelsius(
        float firstTemp)
    {
        float celsiusTemp = (firstTemp - 32) * 5 / 9;
        if (float.IsPositiveInfinity(celsiusTemp) || float.IsNegativeInfinity(celsiusTemp))
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
    public static float FahrenheitToFahrenheit(
        float firstTemp)
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
    public static float FahrenheitToKelvin(
        float firstTemp)
    {
        float celsiusTemp = FahrenheitToCelsius(firstTemp);
        float kelvinTemp = CelsiusFloatConversions.CelsiusToKelvin(celsiusTemp);
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
    public static float FahrenheitToGas(
        float firstTemp)
    {
        float celsiusTemp = FahrenheitToCelsius(firstTemp);
        float gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusTemp);
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
    public static float FahrenheitToRankine(
        float firstTemp)
    {
        float rankineTemp = firstTemp + 459.67f;
        return rankineTemp;
    }
}
