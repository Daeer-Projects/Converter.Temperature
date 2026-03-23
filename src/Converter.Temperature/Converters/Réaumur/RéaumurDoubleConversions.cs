using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Réaumur;

/// <summary>
///     The réaumur double conversions.
/// </summary>
internal static class RéaumurDoubleConversions
{
    /// <summary>
    ///     The réaumur to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToCelsius(double input)
    {
        return input * 5d / 4d;
    }

    /// <summary>
    ///     The réaumur to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToFahrenheit(double input)
    {
        return (input * 9d / 4d) + 32d;
    }

    /// <summary>
    ///     The réaumur to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToKelvin(double input)
    {
        return (input * 5d / 4d) + 273.15d;
    }

    /// <summary>
    ///     The réaumur to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToGas(double input)
    {
        double celsiusResult = RéaumurToCelsius(input);
        return CelsiusDoubleConversions.CelsiusToGas(celsiusResult);
    }

    /// <summary>
    ///     The réaumur to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToRankine(double input)
    {
        return (input * 9d / 4d) + 491.67d;
    }

    /// <summary>
    ///     The réaumur to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToRømer(double input)
    {
        return input * 21d / 32d + 7.5d;
    }

    /// <summary>
    ///     The réaumur to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToDelisle(double input)
    {
        return (80d - input) * 15d / 8d;
    }

    /// <summary>
    ///     The réaumur to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToNewton(double input)
    {
        return input * 33d / 80d;
    }

    /// <summary>
    ///     The réaumur to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RéaumurToRéaumur(double input)
    {
        return input;
    }
}
