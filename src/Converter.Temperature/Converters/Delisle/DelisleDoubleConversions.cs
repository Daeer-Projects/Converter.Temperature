namespace Converter.Temperature.Converters.Delisle;

using System;

internal static class DelisleDoubleConversions
{
    /// <summary>
    ///     The Delisle to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToCelsius(
        double input)
    {
        double celsiusResult = 100 - input * 2 / 3;
        if (double.IsPositiveInfinity(celsiusResult) || double.IsNegativeInfinity(celsiusResult))
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
    internal static double DelisleToFahrenheit(
        double input)
    {
        double fahrenheitResult = 212 - input * 6 / 5;
        if (double.IsPositiveInfinity(fahrenheitResult) || double.IsNegativeInfinity(fahrenheitResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return fahrenheitResult;
    }
}
