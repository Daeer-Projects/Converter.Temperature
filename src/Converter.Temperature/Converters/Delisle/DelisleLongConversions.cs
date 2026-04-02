using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Delisle;

internal static class DelisleLongConversions
{
    /// <summary>
    ///     The Delisle to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToCelsius(
        long input)
    {
        double result = 100d - input * 2d / 3d;
        if (result < (double)long.MinValue - 0.5d || result > (double)long.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToFahrenheit(
        long input)
    {
        double result = 212d - input * 6d / 5d;
        if (result < (double)long.MinValue - 0.5d || result > (double)long.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToKelvin(
        long input)
    {
        double result = 373.15d - input * 2d / 3d;
        if (result < (double)long.MinValue - 0.5d || result > (double)long.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
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
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToRankine(
        long input)
    {
        double result = 671.67d - input * 6d / 5d;
        if (result < (double)long.MinValue - 0.5d || result > (double)long.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToRømer(
        long input)
    {
        double result = (100d - input * 2d / 3d) * 21d / 40d + 7.5d;
        if (result < (double)long.MinValue - 0.5d || result > (double)long.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
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
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToNewton(
        long input)
    {
        double result = (100d - input * 2d / 3d) * 33d / 100d;
        if (result < (double)long.MinValue - 0.5d || result > (double)long.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long DelisleToRéaumur(
        long input)
    {
        double result = (100d - input * 2d / 3d) * 4d / 5d;
        if (result < (double)long.MinValue - 0.5d || result > (double)long.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }
}
