namespace Converter.Temperature.Converters.Rømer;

using System;
using Celsius;

internal static class RømerDoubleConversions
{
    /// <summary>
    ///     The rømer to celsius conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RømerToCelsius(double input)
    {
        double celsiusTemp = (input - 7.5d) * 40d / 21d;
        return celsiusTemp;
    }

    /// <summary>
    ///     The rømer to fahrenheit conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RømerToFahrenheit(double input)
    {
        double fahrenheitTemp = (input - 7.5d) * 24d / 7d + 32d;
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
    internal static double RømerToKelvin(double input)
    {
        double kelvinTemp = (input - 7.5d) * 40d / 21d + 273.15d;
        if (double.IsPositiveInfinity(kelvinTemp) || double.IsNegativeInfinity(kelvinTemp))
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

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
    internal static double RømerToGas(double input)
    {
        double celsiusTemp = RømerToCelsius(input);
        double gasTemp = CelsiusDoubleConversions.CelsiusToGas(celsiusTemp);
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
    internal static double RømerToRankine(double input)
    {
        double rankineTemp = (input - 7.5d) * 24d / 7d + 491.67d;
        if (double.IsPositiveInfinity(rankineTemp) || double.IsNegativeInfinity(rankineTemp))
            throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);

        return rankineTemp;
    }

    /// <summary>
    ///     The rømer to rømer conversion.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The converted temperature.
    /// </returns>
    internal static double RømerToRømer(double input)
    {
        return input;
    }
}
