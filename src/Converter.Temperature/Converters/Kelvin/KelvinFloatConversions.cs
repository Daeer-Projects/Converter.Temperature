namespace Converter.Temperature.Converters.Kelvin;

using System;
using Celsius;

internal static class KelvinFloatConversions
{
    /// <summary>
    ///     The kelvin to celsius conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float KelvinToCelsius(
        float firstTemp)
    {
        float celsiusTemp = firstTemp - 273.15f;
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
    internal static float KelvinToFahrenheit(
        float firstTemp)
    {
        float celsiusTemp = KelvinToCelsius(firstTemp);
        float fahrenheitTemp = CelsiusFloatConversions.CelsiusToFahrenheit(celsiusTemp);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The kelvin to kelvin conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float KelvinToKelvin(
        float firstTemp)
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
    internal static float KelvinToGas(
        float firstTemp)
    {
        float celsiusTemp = KelvinToCelsius(firstTemp);
        float gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusTemp);
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
    internal static float KelvinToRankine(
        float firstTemp)
    {
        float rankineTemp = firstTemp * 9 / 5;
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
    internal static float KelvinToRømer(
        float input)
    {
        float rømerTemp = (input - 273.15f) * 21 / 40 + 7.5f;
        if (float.IsPositiveInfinity(rømerTemp) || float.IsNegativeInfinity(rømerTemp))
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        return rømerTemp;
    }
}
