namespace Converter.Temperature.Converters.Delisle;

using System;
using Celsius;

internal static class DelisleLongConversions
{
    /// <summary>
    ///     The Delisle to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToCelsius(
        long input)
    {
        const double calculatedValue = 100d - 1 * 2d / 3d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = 100d - input * 2d / 3d;
        long celsiusResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
        
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
    internal static long DelisleToFahrenheit(
        long input)
    {
        const double calculatedValue = 212d - 1 * 6d / 5d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = 212d - input * 6d / 5d;
        long fahrenheitResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long DelisleToKelvin(
        long input)
    {
        const double calculatedValue = 373.15d - 1 * 2d / 3d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = 373.15 - input * 2d / 3d;
        long kelvinResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
        
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
    internal static long DelisleToGas(
        long input)
    {
        long gasResult = DelisleToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(gasResult);
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
    internal static long DelisleToRankine(
        long input)
    {
        const double calculatedValue = 671.67d - 1 * 6d / 5d;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = 671.67 - input * 6d / 5d;
        long rankineResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long DelisleToRømer(
        long input)
    {
        const double calculatedValue = (100 - 1 * 2d / 3d) * 21 / 40 + 7.5;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (100 - input * 2d / 3d) * 21 / 40 + 7.5;
        long rømerResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long DelisleToDelisle(
        long input)
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
    internal static long DelisleToNewton(
        long input)
    {
        const double calculatedValue = (100 - 1 * 2d / 3d) * 33 / 100;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (100 - input * 2d / 3d) * 33 / 100;
        long newtonResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long DelisleToRéaumur(
        long input)
    {
        const double calculatedValue = (100 - 1 * 2d / 3d) * 4 / 5;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (100 - input * 2d / 3d) * 4 / 5;
        long réaumurResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return réaumurResult;
    }
}
