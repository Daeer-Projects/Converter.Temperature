namespace Converter.Temperature.Converters.Rømer;

using System;
using Celsius;

internal static class RømerFloatConversions
{
    /// <summary>
    ///     The rømer to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RømerToCelsius(float input)
    {
        float celsiusTemp = (input - 7.5f) * 40 / 21;
        return celsiusTemp;
    }

    /// <summary>
    ///     The rømer to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RømerToFahrenheit(float input)
    {
        float fahrenheitTemp = (input - 7.5f) * 24 / 7 + 32;
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The rømer to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RømerToKelvin(float input)
    {
        float kelvinTemp = (input - 7.5f) * 40 / 21 + 273.15f;
        if (float.IsPositiveInfinity(kelvinTemp) || float.IsNegativeInfinity(kelvinTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return kelvinTemp;
    }

    /// <summary>
    ///     The rømer to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RømerToGas(float input)
    {
        float celsiusTemp = RømerToCelsius(input);
        float gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The rømer to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RømerToRankine(float input)
    {
        float rankineTemp = (input - 7.5f) * 24 / 7 + 491.67f;
        if (float.IsPositiveInfinity(rankineTemp) || float.IsNegativeInfinity(rankineTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rankineTemp;
    }

    /// <summary>
    ///     The rømer to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RømerToRømer(float input)
    {
        return input;
    }
}