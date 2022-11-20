namespace Converter.Temperature.Converters.Celsius;

using System;

internal static class CelsiusFloatConversions
{
    /// <summary>
    ///     The celsius to celsius conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static float CelsiusToCelsius(float firstTemp)
    {
        return firstTemp;
    }

    /// <summary>
    ///     The celsius to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static float CelsiusToFahrenheit(float input)
    {
        float fahrenheitTemp = input * 1.8f + 32;
        if (float.IsPositiveInfinity(fahrenheitTemp) || float.IsNegativeInfinity(fahrenheitTemp))
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        return fahrenheitTemp;
    }

    /// <summary>
    ///     The celsius to kelvin conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    public static float CelsiusToKelvin(float input)
    {
        float kelvinTemp = input * 1.01f + 273.15f;
        if (float.IsPositiveInfinity(kelvinTemp) || float.IsNegativeInfinity(kelvinTemp))
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        kelvinTemp = input * 1f + 273.15f;

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
    public static float CelsiusToGas(float input)
    {
        float gasTemp = input switch
        {
            < 80 => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooLowForGasError),
            < 115 => 0.25f,
            < 135 => 0.5f,
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
    public static float CelsiusToRankine(float input)
    {
        float rankineTemp = (input + 273.15f) * 9 / 5;
        if (float.IsPositiveInfinity(rankineTemp) || float.IsNegativeInfinity(rankineTemp))
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        return rankineTemp;
    }
}