using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Rankine;

internal static class RankineFloatConversions
{
    /// <summary>
    ///     The rankine to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToRankine(
        float input)
    {
        return input;
    }

    /// <summary>
    ///     The rankine to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToCelsius(
        float input)
    {
        float rankineTemp = (input - 491.67f) * 5 / 9;
        if (float.IsPositiveInfinity(rankineTemp) || float.IsNegativeInfinity(rankineTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rankineTemp;
    }

    /// <summary>
    ///     The rankine to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToFahrenheit(
        float input)
    {
        float rankineTemp = input - 459.67f;
        return rankineTemp;
    }

    /// <summary>
    ///     The rankine to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToKelvin(
        float input)
    {
        float rankineTemp = input * 5 / 9;
        return rankineTemp;
    }

    /// <summary>
    ///     The rankine to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToGas(
        float input)
    {
        float celsiusTemp = RankineToCelsius(input);
        float gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The rankine to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToRømer(
        float input)
    {
        float rømerTemp = (input - 491.67f) * 7 / 24 + 7.5f;
        if (float.IsPositiveInfinity(rømerTemp) || float.IsNegativeInfinity(rømerTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerTemp;
    }

    /// <summary>
    ///     The rankine to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToDelisle(
        float input)
    {
        float delisleTemp = (671.67f - input) * 5f / 6f;
        if (float.IsPositiveInfinity(delisleTemp) || float.IsNegativeInfinity(delisleTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return delisleTemp;
    }

    /// <summary>
    ///     The rankine to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToNewton(
        float input)
    {
        float newtonTemp = (input - 491.67f) * 11 / 60;
        if (float.IsPositiveInfinity(newtonTemp) || float.IsNegativeInfinity(newtonTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return newtonTemp;
    }

    /// <summary>
    ///     The rankine to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RankineToRéaumur(
        float input)
    {
        float réaumurTemp = (input - 491.67f) * 4 / 9;
        if (float.IsPositiveInfinity(réaumurTemp) || float.IsNegativeInfinity(réaumurTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurTemp;
    }
}

