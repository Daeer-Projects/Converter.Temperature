using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Newton;

internal static class NewtonDoubleConversions
{
    /// <summary>
    ///     The Newton to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double NewtonToCelsius(
        double input)
    {
        double celsiusResult = input * 100d / 33d;
        if (double.IsPositiveInfinity(celsiusResult) || double.IsNegativeInfinity(celsiusResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

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
    internal static double NewtonToFahrenheit(
        double input)
    {
        double fahrenheitResult = input * 60d / 11d + 32d;
        if (double.IsPositiveInfinity(fahrenheitResult) || double.IsNegativeInfinity(fahrenheitResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

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
    internal static double NewtonToKelvin(
        double input)
    {
        double kelvinResult = input * 100d / 33d + 273.15d;
        if (double.IsPositiveInfinity(kelvinResult) || double.IsNegativeInfinity(kelvinResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

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
    internal static double NewtonToGas(
        double input)
    {
        double celsiusResult = NewtonToCelsius(input);
        double gasTemp = CelsiusDoubleConversions.CelsiusToGas(celsiusResult);
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
    internal static double NewtonToRankine(
        double input)
    {
        double rankineResult = input * 60d / 11d + 491.67d;
        if (double.IsPositiveInfinity(rankineResult) || double.IsNegativeInfinity(rankineResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

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
    internal static double NewtonToRømer(
        double input)
    {
        double rømerResult = input * 35d / 22d + 7.5d;
        if (double.IsPositiveInfinity(rømerResult) || double.IsNegativeInfinity(rømerResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

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
    internal static double NewtonToDelisle(
        double input)
    {
        double delisleResult = (33d - input) * 50d / 11d;
        if (double.IsPositiveInfinity(delisleResult) || double.IsNegativeInfinity(delisleResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return delisleResult;
    }

    /// <summary>
    ///     The Newton to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double NewtonToNewton(
        double input)
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
    internal static double NewtonToRéaumur(
        double input)
    {
        double réaumurResult = input * 80d / 33d;
        if (double.IsPositiveInfinity(réaumurResult) || double.IsNegativeInfinity(réaumurResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurResult;
    }
}
