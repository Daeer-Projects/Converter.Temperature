using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Delisle;

internal static class DelisleFloatConversions
{
    /// <summary>
    ///     The Delisle to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToCelsius(
        float input)
    {
        float celsiusResult = 100f - input * 2f / 3f;
        if (float.IsPositiveInfinity(celsiusResult) || float.IsNegativeInfinity(celsiusResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return celsiusResult;
    }
    
    /// <summary>
    ///     The Delisle to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToFahrenheit(
        float input)
    {
        float fahrenheitResult = 212f - input * 1.2f;
        if (float.IsPositiveInfinity(fahrenheitResult) || float.IsNegativeInfinity(fahrenheitResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return fahrenheitResult;
    }
    
    /// <summary>
    ///     The Delisle to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToKelvin(
        float input)
    {
        float kelvinResult = 373.15f - input * 2f / 3f;
        if (float.IsPositiveInfinity(kelvinResult) || float.IsNegativeInfinity(kelvinResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return kelvinResult;
    }
    
    /// <summary>
    ///     The Delisle to Gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToGas(
        float input)
    {
        float gasResult = DelisleToCelsius(input);
        float gasTemp = CelsiusFloatConversions.CelsiusToGas(gasResult);
        return gasTemp;
    }
    
    /// <summary>
    ///     The Delisle to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToRankine(
        float input)
    {
        float rankineResult = 671.67f - input * 0.8f;
        if (float.IsPositiveInfinity(rankineResult) || float.IsNegativeInfinity(rankineResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rankineResult;
    }
    
    /// <summary>
    ///     The Delisle to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToRømer(
        float input)
    {
        float rømerResult = (100f - input * 2f / 3f) * 21f / 40f + 7.5f;
        if (float.IsPositiveInfinity(rømerResult) || float.IsNegativeInfinity(rømerResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerResult;
    }
    
    /// <summary>
    ///     The Delisle to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToDelisle(
        float input)
    {
        return input;
    }
    
    /// <summary>
    ///     The Delisle to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToNewton(
        float input)
    {
        float newtonResult = (100f - input * 2f / 3f) * 33f / 100f;
        if (float.IsPositiveInfinity(newtonResult) || float.IsNegativeInfinity(newtonResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return newtonResult;
    }
    
    /// <summary>
    ///     The Delisle to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float DelisleToRéaumur(
        float input)
    {
        float réaumurResult = (100f - input * 2f / 3f) * 0.8f;
        if (float.IsPositiveInfinity(réaumurResult) || float.IsNegativeInfinity(réaumurResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurResult;
    }
}
