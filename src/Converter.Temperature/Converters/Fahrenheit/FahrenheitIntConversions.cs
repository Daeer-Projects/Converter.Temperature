namespace Converter.Temperature.Converters.Fahrenheit;

using System;
using Celsius;

internal static class FahrenheitIntConversions
{
    /// <summary>
    ///     The fahrenheit to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToCelsius(int input)
    {
        double calculatedValue = (input - 32d) * 5 / 9;
        int celsiusTemp = (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        return celsiusTemp;
    }

    /// <summary>
    ///     The fahrenheit to fahrenheit conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToFahrenheit(int firstTemp)
    {
        return firstTemp;
    }

    /// <summary>
    ///     The fahrenheit to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToKelvin(int input)
    {
        double calculatedValue = (input - 32d) * 5 / 9 + 273.15d;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        int kelvinTemp = (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);

        return kelvinTemp;
    }

    /// <summary>
    ///     The fahrenheit to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToGas(int input)
    {
        int celsiusTemp = FahrenheitToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The fahrenheit to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToRankine(int input)
    {
        const int maxValue = int.MaxValue - 460;
        const int minValue = int.MinValue + 460;
        if (input is < minValue or > maxValue)
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        int rankineTemp = input + 460;
        return rankineTemp;
    }

    /// <summary>
    ///     The fahrenheit to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToRømer(int input)
    {
        float result = (input - 491.67f) * 7 / 24 + 7.5f;
        int rømerTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }
}