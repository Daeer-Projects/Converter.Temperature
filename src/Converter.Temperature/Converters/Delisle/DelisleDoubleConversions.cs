using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Delisle;

internal static class DelisleDoubleConversions
{
    /// <summary>
    ///     The Delisle to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToCelsius(
        double input)
    {
        double celsiusResult = 100d - input * 2d / 3d;
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
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToFahrenheit(
        double input)
    {
        double fahrenheitResult = 212d - input * 6d / 5d;
        if (double.IsPositiveInfinity(fahrenheitResult) || double.IsNegativeInfinity(fahrenheitResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return fahrenheitResult;
    }

    /// <summary>
    ///     The Delisle to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToKelvin(
        double input)
    {
        double kelvinResult = 373.15d - input * 2d / 3d;
        if (double.IsPositiveInfinity(kelvinResult) || double.IsNegativeInfinity(kelvinResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return kelvinResult;
    }

    /// <summary>
    ///     The Delisle to Gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToGas(
        double input)
    {
        double gasResult = DelisleToCelsius(input);
        double gasTemp = CelsiusDoubleConversions.CelsiusToGas(gasResult);
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
    internal static double DelisleToRankine(
        double input)
    {
        double rankineResult = 671.67d - input * 6d / 5d;
        if (double.IsPositiveInfinity(rankineResult) || double.IsNegativeInfinity(rankineResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rankineResult;
    }

    /// <summary>
    ///     The Delisle to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToRømer(
        double input)
    {
        double rømerResult = (100d - input * 2d / 3d) * 21d / 40d + 7.5d;
        if (double.IsPositiveInfinity(rømerResult) || double.IsNegativeInfinity(rømerResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerResult;
    }

    /// <summary>
    ///     The Delisle to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToDelisle(
        double input)
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
    internal static double DelisleToNewton(
        double input)
    {
        double newtonResult = (100d - input * 2d / 3d) * 33d / 100d;
        if (double.IsPositiveInfinity(newtonResult) || double.IsNegativeInfinity(newtonResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return newtonResult;
    }

    /// <summary>
    ///     The Delisle to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double DelisleToRéaumur(
        double input)
    {
        double réaumurResult = (100d - input * 2d / 3d) * 4d / 5d;
        if (double.IsPositiveInfinity(réaumurResult) || double.IsNegativeInfinity(réaumurResult))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurResult;
    }
}
