namespace Converter.Temperature.Converters.Fahrenheit;

using System;
using Celsius;

internal static class FahrenheitLongConversions
{
    /// <summary>
    ///     The Fahrenheit to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToCelsius(
        long input)
    {
        const double calculatedValue = (1 - 32d) * 5 / 9;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (input - 32d) * 5 / 9;
        long celsiusTemp = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return celsiusTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToFahrenheit(
        long input)
    {
        return input;
    }

    /// <summary>
    ///     The Fahrenheit to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToKelvin(
        long input)
    {
        const double calculatedValue = (1 - 32d) * 5 / 9 + 273.15d;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = (input - 32d) * 5 / 9 + 273.15d;
        long kelvinTemp = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return kelvinTemp;
    }

    /// <summary>
    ///     The Fahrenheit to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToGas(
        long input)
    {
        long celsiusTemp = FahrenheitToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRankine(
        long input)
    {
        const long maxValue = long.MaxValue - 460;
        const long minValue = long.MinValue + 460;
        if (input is < minValue or > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        long rankineTemp = input + 460;
        return rankineTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRømer(
        long input)
    {
        const double calculatedValue = (1 - 32d) * 7 / 24 + 7.5;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = (input - 32d) * 7 / 24 + 7.5;
        long rømerTemp = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return rømerTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToDelisle(
        long input)
    {
        const double calculatedValue = (212d - 1) * 5 / 6;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (212d - input) * 5 / 6;
        long delisleTemp = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return delisleTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToNewton(
        long input)
    {
        const double calculatedValue = (1 - 32d) * 11 / 60;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (input - 32d) * 11 / 60;
        long newtonTemp = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return newtonTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRéaumur(
        long input)
    {
        const double calculatedValue = (1 - 32d) * 4 / 9;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (input - 32d) * 4 / 9;
        long réaumurTemp = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return réaumurTemp;
    }
}
