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
    internal static int DelisleToCelsius(int input)
    {
        decimal result = 100m - input * 2m / 3m;
        if (result < int.MinValue - 0.5m || result > int.MaxValue + 0.5m)
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
    internal static int DelisleToFahrenheit(int input)
    {
        decimal result = 212m - input * 6m / 5m;
        if (result < int.MinValue - 0.5m || result > int.MaxValue + 0.5m)
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
    internal static int DelisleToKelvin(int input)
    {
        decimal result = 373.15m - input * 2m / 3m;
        if (result < int.MinValue - 0.5m || result > int.MaxValue + 0.5m)
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
    internal static int DelisleToGas(int input)
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
    internal static int DelisleToRankine(int input)
    {
        decimal result = 671.67m - input * 6m / 5m;
        if (result < int.MinValue - 0.5m || result > int.MaxValue + 0.5m)
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
    internal static int DelisleToRømer(int input)
    {
        decimal result = (100m - input * 2m / 3m) * 21m / 40m + 7.5m;
        if (result < int.MinValue - 0.5m || result > int.MaxValue + 0.5m)
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
    internal static int DelisleToDelisle(int input)
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
    internal static int DelisleToNewton(int input)
    {
        decimal result = (100m - input * 2m / 3m) * 33m / 100m;
        if (result < int.MinValue - 0.5m || result > int.MaxValue + 0.5m)
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
    internal static int DelisleToRéaumur(int input)
    {
        decimal result = (100m - input * 2m / 3m) * 4m / 5m;
        if (result < int.MinValue - 0.5m || result > int.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }
}
