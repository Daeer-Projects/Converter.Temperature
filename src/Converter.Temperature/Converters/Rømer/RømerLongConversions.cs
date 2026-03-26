using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Rømer;

internal static class RømerLongConversions
{
    /// <summary>
    ///     The rømer to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToCelsius(long input)
    {
        double calculatedValue = (input - 7.5d) * 40d / 21d;
        long celsiusTemp = (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        return celsiusTemp;
    }

    /// <summary>
    ///     The rømer to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToFahrenheit(long input)
    {
        double calculatedValue = (input - 7.5d) * 24d / 7d + 32d;
        long fahrenheitTemp = (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The rømer to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToKelvin(long input)
    {
        double calculatedValue = (input - 7.5d) * 40d / 21d + 273.15d;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        long kelvinTemp = (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);

        return kelvinTemp;
    }

    /// <summary>
    ///     The rømer to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToGas(long input)
    {
        long celsiusTemp = RømerToCelsius(input);
        long gasTemp = CelsiusLongConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The rømer to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToRankine(long input)
    {
        double calculatedValue = (input - 7.5d) * 24d / 7d + 491.67d;
        long maxValue = long.MaxValue - (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        long minValue = long.MinValue + (long)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        long rankineTemp = (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);

        return rankineTemp;
    }

    /// <summary>
    ///     The rømer to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToRømer(long input)
    {
        return input;
    }

    /// <summary>
    ///     The rømer to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToDelisle(long input)
    {
        double result = (60d - input) * 20d / 7d;
        long delisleTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return delisleTemp;
    }

    /// <summary>
    ///     The rømer to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToNewton(long input)
    {
        double result = (input - 7.5d) * 22d / 35d;
        long newtonTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return newtonTemp;
    }

    /// <summary>
    ///     The rømer to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static long RømerToRéaumur(long input)
    {
        double result = (input - 7.5d) * 32d / 21d;
        long réaumurTemp = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return réaumurTemp;
    }
}
