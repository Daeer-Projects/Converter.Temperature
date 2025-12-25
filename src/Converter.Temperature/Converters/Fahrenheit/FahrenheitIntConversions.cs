namespace Converter.Temperature.Converters.Fahrenheit;

using System;
using Celsius;

internal static class FahrenheitIntConversions
{
    /// <summary>
    ///     The Fahrenheit to Celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToCelsius(
        int input)
    {
        double convertedTemp = (input - 32d) * 5 / 9;
        int celsiusTemp = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return celsiusTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToFahrenheit(
        int input)
    {
        return input;
    }

    /// <summary>
    ///     The Fahrenheit to Kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToKelvin(
        int input)
    {
        const double calculatedValue = (1 - 32d) * 5 / 9 + 273.15d;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (input - 32d) * 5 / 9 + 273.15d;
        int kelvinTemp = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return kelvinTemp;
    }

    /// <summary>
    ///     The Fahrenheit to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToGas(
        int input)
    {
        int celsiusTemp = FahrenheitToCelsius(input);
        int gasTemp = CelsiusIntConversions.CelsiusToGas(celsiusTemp);
        return gasTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToRankine(
        int input)
    {
        const int maxValue = int.MaxValue - 460;
        const int minValue = int.MinValue + 460;
        if (input is < minValue or > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        int rankineTemp = input + 460;
        return rankineTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToRømer(
        int input)
    {
        const double calculatedValue = (1 - 32d) * 7 / 24 + 7.5;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (input - 32d) * 7 / 24 + 7.5d;
        int rømerTemp = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
        
        return rømerTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToDelisle(
        int input)
    {
        const double calculatedValue = (212d - 1) * 5 / 6;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (212d - input) * 5 / 6;
        int delisleTemp = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return delisleTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToNewton(
        int input)
    {
        const double calculatedValue = (1 - 32d) * 11 / 60;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (input - 32d) * 11 / 60;
        int newtonTemp = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return newtonTemp;
    }

    /// <summary>
    ///     The Fahrenheit to Réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int FahrenheitToRéaumur(
        int input)
    {
        const double calculatedValue = (1 - 32d) * 4 / 9;
        int maxValue = int.MaxValue - (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        int minValue = int.MinValue + (int)Math.Abs(Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero));
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }
        
        double convertedTemp = (input - 32d) * 4 / 9;
        int réaumurTemp = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return réaumurTemp;
    }
}
