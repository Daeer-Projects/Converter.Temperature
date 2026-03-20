using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Newton;

internal static class NewtonIntConversions
{
    /// <summary>
    ///     The Newton to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToCelsius(
        int input)
    {
        const double calculatedValue = 1 * 100d / 33d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 100d / 33d;
        int celsiusResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return celsiusResult;
    }

    /// <summary>
    ///     The Newton to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToFahrenheit(
        int input)
    {
        const double calculatedValue = 1 * 60d / 11d + 32d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 60d / 11d + 32d;
        int fahrenheitResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return fahrenheitResult;
    }

    /// <summary>
    ///     The Newton to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToKelvin(
        int input)
    {
        const double calculatedValue = 1 * 100d / 33d + 273.15d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 100d / 33d + 273.15d;
        int kelvinResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return kelvinResult;
    }

    /// <summary>
    ///     The Newton to Gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToGas(
        int input)
    {
        int celsiusResult = NewtonToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusResult);
        return gasTemp;
    }

    /// <summary>
    ///     The Newton to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToRankine(
        int input)
    {
        const double calculatedValue = 1 * 60d / 11d + 491.67d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 60d / 11d + 491.67d;
        int rankineResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return rankineResult;
    }

    /// <summary>
    ///     The Newton to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToRømer(
        int input)
    {
        const double calculatedValue = 1 * 35d / 22d + 7.5d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 35d / 22d + 7.5d;
        int rømerResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return rømerResult;
    }

    /// <summary>
    ///     The Newton to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToDelisle(
        int input)
    {
        const double calculatedValue = (100d - 1 * 100d / 33d) * 3d / 2d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = (100d - input * 100d / 33d) * 3d / 2d;
        int delisleResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return delisleResult;
    }

    /// <summary>
    ///     The Newton to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToNewton(
        int input)
    {
        return input;
    }

    /// <summary>
    ///     The Newton to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int NewtonToRéaumur(
        int input)
    {
        const double calculatedValue = 1 * 80d / 33d;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 80d / 33d;
        int réaumurResult = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return réaumurResult;
    }
}
