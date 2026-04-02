using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Delisle;

internal static class DelisleIntConversions
{
    /// <summary>
    ///     The Delisle to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToCelsius(
        int input)
    {
        double result = 100d - input * 2d / 3d;
        if (result < (double)int.MinValue - 0.5d || result > (double)int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToFahrenheit(
        int input)
    {
        double result = 212d - input * 6d / 5d;
        if (result < (double)int.MinValue - 0.5d || result > (double)int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToKelvin(
        int input)
    {
        double result = 373.15d - input * 2d / 3d;
        if (result < (double)int.MinValue - 0.5d || result > (double)int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
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
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToRankine(
        int input)
    {
        double result = 671.67d - input * 6d / 5d;
        if (result < (double)int.MinValue - 0.5d || result > (double)int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToRømer(
        int input)
    {
        double result = (100d - input * 2d / 3d) * 21d / 40d + 7.5d;
        if (result < (double)int.MinValue - 0.5d || result > (double)int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
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
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToNewton(
        int input)
    {
        double result = (100d - input * 2d / 3d) * 33d / 100d;
        if (result < (double)int.MinValue - 0.5d || result > (double)int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Delisle to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int DelisleToRéaumur(
        int input)
    {
        double result = (100d - input * 2d / 3d) * 4d / 5d;
        if (result < (double)int.MinValue - 0.5d || result > (double)int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }
}
