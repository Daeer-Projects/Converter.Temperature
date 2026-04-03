using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Fahrenheit;

internal static class FahrenheitLongConversions
{
    /// <summary>
    ///     The Fahrenheit to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToCelsius(
        long input)
    {
        decimal result = (input - 32m) * 5m / 9m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)decimal.Round(result, 0, MidpointRounding.AwayFromZero);
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
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToKelvin(
        long input)
    {
        decimal result = (input + 459.67m) * 5m / 9m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)decimal.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Fahrenheit to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRankine(
        long input)
    {
        decimal result = input + 459.67m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)decimal.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Fahrenheit to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRømer(
        long input)
    {
        decimal result = (input - 32m) * 7m / 24m + 7.5m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)decimal.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Fahrenheit to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToDelisle(
        long input)
    {
        decimal result = (212m - input) * 5m / 6m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)decimal.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Fahrenheit to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToNewton(
        long input)
    {
        decimal result = (input - 32m) * 11m / 60m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)decimal.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Fahrenheit to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long FahrenheitToRéaumur(
        long input)
    {
        decimal result = (input - 32m) * 4m / 9m;
        if (result < long.MinValue - 0.5m || result > long.MaxValue + 0.5m)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (long)decimal.Round(result, 0, MidpointRounding.AwayFromZero);
    }
}
