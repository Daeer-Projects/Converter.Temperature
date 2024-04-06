namespace Converter.Temperature.Converters.Rømer;

using System;
using Celsius;

internal static class RømerIntConversions
{
    /// <summary>
    ///     The rømer to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RømerToCelsius(int input)
    {
        double calculatedValue = (input - 7.5d) * 40d / 21d;
        int celsiusTemp = (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        return celsiusTemp;
    }

    /// <summary>
    ///     The rømer to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RømerToFahrenheit(int input)
    {
        double calculatedValue = (input - 7.5d) * 24d / 7d + 32d;
        int fahrenheitTemp = (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        return fahrenheitTemp;
    }

    /// <summary>
    ///     The rømer to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RømerToKelvin(int input)
    {
        double calculatedValue = (input - 7.5d) * 40d / 21d + 273.15d;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        int kelvinTemp = (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);

        return kelvinTemp;
    }

    /// <summary>
    ///     The rømer to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RømerToGas(int input)
    {
        int celsiusTemp = RømerToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The rømer to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RømerToRankine(int input)
    {
        double calculatedValue = (input - 7.5d) * 24d / 7d + 491.67d;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        int rankineTemp = (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);

        return rankineTemp;
    }

    /// <summary>
    ///     The rømer to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int RømerToRømer(int input)
    {
        return input;
    }
}