using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Réaumur;

/// <summary>
///     The réaumur int conversions.
/// </summary>
internal static class RéaumurIntConversions
{
    /// <summary>
    ///     The réaumur to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToCelsius(int input)
    {
        double convertedTemp = input * 5d / 4d;
        return (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The réaumur to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToFahrenheit(int input)
    {
        double convertedTemp = input * 9d / 4d + 32d;
        return (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The réaumur to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToKelvin(int input)
    {
        double convertedTemp = input * 5d / 4d + 273.15d;
        return (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The réaumur to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToGas(int input)
    {
        int celsiusResult = RéaumurToCelsius(input);
        return CelsiusIntConversions.CelsiusToGas(celsiusResult);
    }

    /// <summary>
    ///     The réaumur to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToRankine(int input)
    {
        double convertedTemp = input * 9d / 4d + 491.67d;
        return (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The réaumur to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToRømer(int input)
    {
        double convertedTemp = input * 21d / 32d + 7.5d;
        return (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The réaumur to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToDelisle(int input)
    {
        double convertedTemp = (80d - input) * 15d / 8d;
        return (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The réaumur to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToNewton(int input)
    {
        double convertedTemp = input * 33d / 80d;
        return (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    ///     The réaumur to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RéaumurToRéaumur(int input)
    {
        return input;
    }
}
