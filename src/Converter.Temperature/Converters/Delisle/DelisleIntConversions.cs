using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Delisle;

internal static class DelisleIntConversions
{
    /// <summary>
    ///     The Delisle to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToCelsius(
        int input)
    {
        const double calculatedValue = 100d - 1 * 2d / 3d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = 100d - input * 2d / 3d;
        int celsiusResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
        
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
    internal static int DelisleToFahrenheit(
        int input)
    {
        int fahrenheitResult = 212 - input * 6 / 5;
        if (int.IsPositiveInfinity(fahrenheitResult) || int.IsNegativeInfinity(fahrenheitResult))
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
    internal static int DelisleToKelvin(
        int input)
    {
        int kelvinResult = 373.15 - input * 2 / 3;
        if (int.IsPositiveInfinity(kelvinResult) || int.IsNegativeInfinity(kelvinResult))
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
    internal static int DelisleToGas(
        int input)
    {
        int gasResult = DelisleToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(gasResult);
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
    internal static int DelisleToRankine(
        int input)
    {
        int rankineResult = 671.67 - input * 4 / 5;
        if (int.IsPositiveInfinity(rankineResult) || int.IsNegativeInfinity(rankineResult))
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
    internal static int DelisleToRømer(
        int input)
    {
        int rømerResult = (100 - input * 2 / 3) * 21 / 40 + 7.5;
        if (int.IsPositiveInfinity(rømerResult) || int.IsNegativeInfinity(rømerResult))
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
    internal static int DelisleToDelisle(
        int input)
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
    internal static int DelisleToNewton(
        int input)
    {
        int newtonResult = (100 - input * 2 / 3) * 33 / 100;
        if (int.IsPositiveInfinity(newtonResult) || int.IsNegativeInfinity(newtonResult))
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
    internal static int DelisleToRéaumur(
        int input)
    {
        int réaumurResult = (100 - input * 2 / 3) * 4 / 5;
        if (int.IsPositiveInfinity(réaumurResult) || int.IsNegativeInfinity(réaumurResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurResult;
    }
}
