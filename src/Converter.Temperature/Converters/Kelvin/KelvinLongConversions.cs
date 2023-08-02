namespace Converter.Temperature.Converters.Kelvin;

using System;
using Celsius;

internal static class KelvinLongConversions
{
    /// <summary>
    ///     The kelvin to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToCelsius(long input)
    {
        const long maxValue = long.MaxValue - 273L;
        const long minValue = long.MinValue + 273L;
        if (input is < minValue or > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        long celsiusTemp = input - 273L;
        return celsiusTemp;
    }

    /// <summary>
    ///     The kelvin to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToFahrenheit(long input)
    {
        long celsiusTemp = KelvinToCelsius(input);
        long fahrenheitTemp = CelsiusLongConversions.CelsiusToFahrenheit(celsiusTemp);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The kelvin to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToKelvin(long input)
    {
        return input;
    }

    /// <summary>
    ///     The kelvin to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToGas(long input)
    {
        long celsiusTemp = KelvinToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The kelvin to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToRankine(long input)
    {
        long rankineTemp = input * 9 / 5;
        return rankineTemp;
    }

    /// <summary>
    ///     The kelvin to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long KelvinToRømer(long input)
    {
        double result = (input - 273.15) * 21 / 40 + 7.5;
        long rømerTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }
}