using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Réaumur;

/// <summary>
///     The réaumur float conversions.
/// </summary>
internal static class RéaumurFloatConversions
{
    /// <summary>
    ///     The réaumur to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToCelsius(float input)
    {
        float celsiusTemp = input * 5f / 4f;
        if (float.IsInfinity(celsiusTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return celsiusTemp;
    }

    /// <summary>
    ///     The réaumur to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToFahrenheit(float input)
    {
        float fahrenheitTemp = input * 9f / 4f + 32f;
        if (float.IsInfinity(fahrenheitTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return fahrenheitTemp;
    }

    /// <summary>
    ///     The réaumur to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToKelvin(float input)
    {
        float kelvinTemp = input * 5f / 4f + 273.15f;
        if (float.IsInfinity(kelvinTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return kelvinTemp;
    }

    /// <summary>
    ///     The réaumur to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToGas(float input)
    {
        float celsiusResult = RéaumurToCelsius(input);
        return CelsiusFloatConversions.CelsiusToGas(celsiusResult);
    }

    /// <summary>
    ///     The réaumur to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToRankine(float input)
    {
        float rankineTemp = input * 9f / 4f + 491.67f;
        if (float.IsInfinity(rankineTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rankineTemp;
    }

    /// <summary>
    ///     The réaumur to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToRømer(float input)
    {
        float rømerTemp = input * 21f / 32f + 7.5f;
        if (float.IsInfinity(rømerTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerTemp;
    }

    /// <summary>
    ///     The réaumur to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToDelisle(float input)
    {
        float delisleTemp = (80f - input) * 15f / 8f;
        if (float.IsInfinity(delisleTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return delisleTemp;
    }

    /// <summary>
    ///     The réaumur to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToNewton(float input)
    {
        float newtonTemp = input * 33f / 80f;
        if (float.IsInfinity(newtonTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return newtonTemp;
    }

    /// <summary>
    ///     The réaumur to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToRéaumur(float input)
    {
        return input;
    }
}
