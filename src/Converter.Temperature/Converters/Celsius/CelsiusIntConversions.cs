using System;

namespace Converter.Temperature.Converters.Celsius;

internal static class CelsiusIntConversions
{
    /// <summary>
    ///     The Celsius to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToCelsius(
        int input)
    {
        return input;
    }

    /// <summary>
    ///     The Celsius to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToFahrenheit(
        int input)
    {
        double result = input * 1.8d + 32d;
        if (result < int.MinValue - 0.5d || result > int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Celsius to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToKelvin(
        int input)
    {
        double result = input + 273.15d;
        if (result < int.MinValue - 0.5d || result > int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Celsius to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToGas(
        int input)
    {
        int gasTemp = input switch
        {
            < 135 => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooLowForGasError),
            < 145 => 1,
            < 155 => 2,
            < 175 => 3,
            < 185 => 4,
            < 195 => 5,
            < 210 => 6,
            < 225 => 7,
            < 235 => 8,
            < 245 => 9,
            < 270 => 10,
            _ => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooHighForGasError)
        };

        return gasTemp;
    }

    /// <summary>
    ///     The Celsius to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToRankine(
        int input)
    {
        double result = (input + 273.15d) * 1.8d;
        if (result < int.MinValue - 0.5d || result > int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Celsius to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToRømer(
        int input)
    {
        double result = input * 21d / 40d + 7.5d;
        if (result < int.MinValue - 0.5d || result > int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Celsius to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToDelisle(
        int input)
    {
        double result = (100d - input) * 1.5d;
        if (result < int.MinValue - 0.5d || result > int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Celsius to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToNewton(
        int input)
    {
        double result = input * 33d / 100d;
        if (result < int.MinValue - 0.5d || result > int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The Celsius to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToRéaumur(
        int input)
    {
        double result = input * 0.8d;
        if (result < int.MinValue - 0.5d || result > int.MaxValue + 0.5d)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
    }
}
