namespace Converter.Temperature.Converters.Celsius;

using System;

internal static class CelsiusDoubleConversions
{
    /// <summary>
    ///     The celsius to celsius conversion.
    /// </summary>
    /// <param name="firstTemp"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double CelsiusToCelsius(
        double firstTemp)
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
    internal static double CelsiusToFahrenheit(
        double input)
    {
        double fahrenheitTemp = input * 9 / 5 + 32;
        if (double.IsPositiveInfinity(fahrenheitTemp) || double.IsNegativeInfinity(fahrenheitTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

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
    internal static double CelsiusToKelvin(
        double input)
    {
        double kelvinTemp = input * 1.01d + 273.15d;
        if (double.IsPositiveInfinity(kelvinTemp) || double.IsNegativeInfinity(kelvinTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        kelvinTemp = input + 273.15d;

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
    internal static double CelsiusToGas(
        double input)
    {
        double gasTemp = input switch
        {
            < 80 => throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooLowForGasError),
            < 115 => 0.25,
            < 135 => 0.5,
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
    internal static double CelsiusToRankine(
        double input)
    {
        double rankineTemp = (input + 273.15) * 9 / 5;
        if (double.IsPositiveInfinity(rankineTemp) || double.IsNegativeInfinity(rankineTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rankineTemp;
    }

    /// <summary>
    ///     The celsius to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double CelsiusToRømer(
        double input)
    {
        double rømerTemp = input * 21 / 40 + 7.5;
        if (double.IsPositiveInfinity(rømerTemp) || double.IsNegativeInfinity(rømerTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return rømerTemp;
    }

    /// <summary>
    ///     The celsius to delisle conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double CelsiusToDelisle(
        double input)
    {
        double delisleTemp = (100 - input) * 3 / 2;
        if (double.IsPositiveInfinity(delisleTemp) || double.IsNegativeInfinity(delisleTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return delisleTemp;
    }

    /// <summary>
    ///     The celsius to newton conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double CelsiusToNewton(
        double input)
    {
        double newtonTemp = input * 33 / 100;
        if (double.IsPositiveInfinity(newtonTemp) || double.IsNegativeInfinity(newtonTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return newtonTemp;
    }

    /// <summary>
    ///     The celsius to réaumur conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double CelsiusToRéaumur(
        double input)
    {
        double réaumurTemp = input * 4 / 5;
        if (double.IsPositiveInfinity(réaumurTemp) || double.IsNegativeInfinity(réaumurTemp))
        {
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
        }

        return réaumurTemp;
    }
}
