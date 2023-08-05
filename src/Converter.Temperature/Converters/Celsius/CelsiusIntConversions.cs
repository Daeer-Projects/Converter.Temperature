namespace Converter.Temperature.Converters.Celsius;

using System;

internal static class CelsiusIntConversions
{
    /// <summary>
    ///     The celsius to celsius conversion.
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
    ///     The celsius to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToFahrenheit(
        int input)
    {
        const double calculatedValue = 1 * 1.8 + 32;
        int maxValue = int.MaxValue - (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        int minValue = int.MinValue + (int)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double convertedTemp = input * 1.8 + 32;
        int fahrenheitTempInt = (int)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return fahrenheitTempInt;
    }

    /// <summary>
    ///     The celsius to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToKelvin(
        int input)
    {
        const int maxValue = int.MaxValue - 273;
        const int minValue = int.MinValue + 273;
        if (input is < minValue or > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        int kelvinTempInt = input + 273;

        return kelvinTempInt;
    }

    /// <summary>
    ///     The celsius to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
    ///     The celsius to rankine conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToRankine(
        int input)
    {
        const int minValue = int.MinValue + 492;
        const int maxValue = int.MaxValue - 492;
        if (input is < minValue or > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        double result = (input + 273.15d) * 9 / 5;
        int rankineTempInt = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);

        return rankineTempInt;
    }

    /// <summary>
    ///     The celsius to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static int CelsiusToRømer(
        int input)
    {
        double result = input * 21d / 40 + 7.5;
        int rømerTemp = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);
        return rømerTemp;
    }
}
