using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Réaumur;

/// <summary>
///     The réaumur float conversions.
/// </summary>
internal static class RéaumurFloatConversions
{
    /// <summary>
    ///     The réaumur to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToCelsius(float input)
    {
        return input * 5f / 4f;
    }

    /// <summary>
    ///     The réaumur to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToFahrenheit(float input)
    {
        return input * 9f / 4f + 32f;
    }

    /// <summary>
    ///     The réaumur to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToKelvin(float input)
    {
        return input * 5f / 4f + 273.15f;
    }

    /// <summary>
    ///     The réaumur to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToGas(float input)
    {
        float celsiusResult = RéaumurToCelsius(input);
        return CelsiusFloatConversions.CelsiusToGas(celsiusResult);
    }

    /// <summary>
    ///     The réaumur to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToRankine(float input)
    {
        return input * 9f / 4f + 491.67f;
    }

    /// <summary>
    ///     The réaumur to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToRømer(float input)
    {
        return input * 21f / 32f + 7.5f;
    }

    /// <summary>
    ///     The réaumur to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToDelisle(float input)
    {
        return (80f - input) * 15f / 8f;
    }

    /// <summary>
    ///     The réaumur to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToNewton(float input)
    {
        return input * 33f / 80f;
    }

    /// <summary>
    ///     The réaumur to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static float RéaumurToRéaumur(float input)
    {
        return input;
    }
}
