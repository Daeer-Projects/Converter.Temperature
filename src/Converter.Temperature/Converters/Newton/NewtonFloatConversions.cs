using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Newton;

internal static class NewtonFloatConversions
{
    /// <summary>
    ///     The Newton to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToCelsius(
        float input)
    {
        float celsiusResult = input * 100f / 33f;
        if (float.IsPositiveInfinity(celsiusResult) || float.IsNegativeInfinity(celsiusResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return celsiusResult;
    }

    /// <summary>
    ///     The Newton to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToFahrenheit(
        float input)
    {
        float fahrenheitResult = input * 60f / 11f + 32f;
        if (float.IsPositiveInfinity(fahrenheitResult) || float.IsNegativeInfinity(fahrenheitResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return fahrenheitResult;
    }

    /// <summary>
    ///     The Newton to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToKelvin(
        float input)
    {
        float kelvinResult = input * 100f / 33f + 273.15f;
        if (float.IsPositiveInfinity(kelvinResult) || float.IsNegativeInfinity(kelvinResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return kelvinResult;
    }

    /// <summary>
    ///     The Newton to Gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToGas(
        float input)
    {
        float celsiusResult = NewtonToCelsius(input);
        float gasTemp = CelsiusFloatConversions.CelsiusToGas(celsiusResult);
        return gasTemp;
    }

    /// <summary>
    ///     The Newton to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToRankine(
        float input)
    {
        float rankineResult = input * 60f / 11f + 491.67f;
        if (float.IsPositiveInfinity(rankineResult) || float.IsNegativeInfinity(rankineResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rankineResult;
    }

    /// <summary>
    ///     The Newton to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToRømer(
        float input)
    {
        float rømerResult = input * 35f / 22f + 7.5f;
        if (float.IsPositiveInfinity(rømerResult) || float.IsNegativeInfinity(rømerResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerResult;
    }

    /// <summary>
    ///     The Newton to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToDelisle(
        float input)
    {
        float delisleResult = (33f - input) * 50f / 11f;
        if (float.IsPositiveInfinity(delisleResult) || float.IsNegativeInfinity(delisleResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return delisleResult;
    }

    /// <summary>
    ///     The Newton to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToNewton(
        float input)
    {
        return input;
    }

    /// <summary>
    ///     The Newton to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float NewtonToRéaumur(
        float input)
    {
        float réaumurResult = input * 80f / 33f;
        if (float.IsPositiveInfinity(réaumurResult) || float.IsNegativeInfinity(réaumurResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurResult;
    }
}

