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
        decimal result = input * 100m / 33m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
        decimal result = input * 60m / 11m + 32m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
        decimal result = input * 100m / 33m + 273.15m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
        decimal result = input * 60m / 11m + 491.67m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
        decimal result = input * 35m / 22m + 7.5m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
        decimal result = (33m - input) * 50m / 11m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
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
        decimal result = input * 80m / 33m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }
}
