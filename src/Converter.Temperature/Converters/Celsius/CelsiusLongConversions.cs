namespace Converter.Temperature.Converters.Celsius;

using System;

internal static class CelsiusLongConversions
{
    /// <summary>
    ///     The celsius to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static long CelsiusToCelsius(long input)
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
    public static long CelsiusToFahrenheit(long input)
    {
        const double calculatedValue = 1 * 1.8 + 32;
        long maxValue = long.MaxValue - (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        long minValue = long.MinValue + (long)Math.Round(calculatedValue, 0, MidpointRounding.AwayFromZero);
        if (input < minValue || input > maxValue)
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        double convertedTemp = input * 1.8 + 32;
        long fahrenheitTempLong = (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);

        return fahrenheitTempLong;
    }

    /// <summary>
    ///     The celsius to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static long CelsiusToKelvin(long input)
    {
        const long maxValue = long.MaxValue - 273L;
        const long minValue = long.MinValue + 273L;
        if (input is < minValue or > maxValue)
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        long kelvinTemp = input + 273L;

        return kelvinTemp;
    }

    /// <summary>
    ///     The celsius to gas conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static long CelsiusToGas(long input)
    {
        long gasTemp = input switch
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
    public static long CelsiusToRankine(long input)
    {
        const long minValue = long.MinValue + 492;
        const long maxValue = long.MaxValue - 492;
        if (input is < minValue or > maxValue)
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        double result = (input + 273.15d) * 9 / 5;
        long rankineTempLong = (long)Math.Round(result, 0, MidpointRounding.AwayFromZero);

        return rankineTempLong;
    }
}