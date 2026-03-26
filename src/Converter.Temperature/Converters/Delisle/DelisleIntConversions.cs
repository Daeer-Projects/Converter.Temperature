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
        const double calculatedValue = 100d - 1 * 2d / 3d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = 100d - input * 2d / 3d;
        int celsiusResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static int DelisleToFahrenheit(
        int input)
    {
        const double calculatedValue = 212d - 1 * 6d / 5d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = 212d - input * 6d / 5d;
        int fahrenheitResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static int DelisleToKelvin(
        int input)
    {
        const double calculatedValue = 373.15d - 1 * 2d / 3d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = 373.15 - input * 2d / 3d;
        int kelvinResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
        const double calculatedValue = 671.67d - 1 * 6d / 5d;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = 671.67 - input * 6d / 5d;
        int rankineResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static int DelisleToRømer(
        int input)
    {
        const double calculatedValue = (100 - 1 * 2d / 3d) * 21 / 40 + 7.5;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = (100 - input * 2d / 3d) * 21 / 40 + 7.5;
        int rømerResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
        const double calculatedValue = (100 - 1 * 2d / 3d) * 33 / 100;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = (100 - input * 2d / 3d) * 33 / 100;
        int newtonResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

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
    internal static int DelisleToRéaumur(
        int input)
    {
        const double calculatedValue = (100 - 1 * 2d / 3d) * 4 / 5;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = (100 - input * 2d / 3d) * 4 / 5;
        int réaumurResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return réaumurResult;
    }
}
