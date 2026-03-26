using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Newton;

internal static class NewtonLongConversions
{
    /// <summary>
    ///     The Newton to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long NewtonToCelsius(
        long input)
    {
        const double calculatedValue = 1 * 100d / 33d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 100d / 33d;
        long celsiusResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long NewtonToFahrenheit(
        long input)
    {
        const double calculatedValue = 1 * 60d / 11d + 32d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 60d / 11d + 32d;
        long fahrenheitResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long NewtonToKelvin(
        long input)
    {
        const double calculatedValue = 1 * 100d / 33d + 273.15d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 100d / 33d + 273.15d;
        long kelvinResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long NewtonToGas(
        long input)
    {
        long celsiusResult = NewtonToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusResult);
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
    internal static long NewtonToRankine(
        long input)
    {
        const double calculatedValue = 1 * 60d / 11d + 491.67d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 60d / 11d + 491.67d;
        long rankineResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long NewtonToRømer(
        long input)
    {
        const double calculatedValue = 1 * 35d / 22d + 7.5d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 35d / 22d + 7.5d;
        long rømerResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static long NewtonToDelisle(
        long input)
    {
        const double calculatedValue = (33d - 1) * 50d / 11d;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = (33d - input) * 50d / 11d;
        long delisleResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return delisleResult;
    }

    /// <summary>
    ///     The Newton to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long NewtonToNewton(
        long input)
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
    internal static long NewtonToRéaumur(
        long input)
    {
        const double calculatedValue = 1 * 80d / 33d;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 80d / 33d;
        long réaumurResult = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return réaumurResult;
    }
}
