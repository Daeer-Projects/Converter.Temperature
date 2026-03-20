using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Réaumur;

internal static class RéaumurDoubleConversions
{
    internal static double RéaumurToCelsius(double input)
    {
        return input * 1.25d;
    }

    internal static double RéaumurToFahrenheit(double input)
    {
        return input * 2.25d + 32d;
    }

    internal static double RéaumurToKelvin(double input)
    {
        return input * 1.25d + 273.15d;
    }

    internal static double RéaumurToGas(double input)
    {
        double celsiusResult = RéaumurToCelsius(input);
        return CelsiusDoubleConversions.CelsiusToGas(celsiusResult);
    }

    internal static double RéaumurToRankine(double input)
    {
        return input * 2.25d + 491.67d;
    }

    internal static double RéaumurToRømer(double input)
    {
        return input * 21d / 32d + 7.5d;
    }

    internal static double RéaumurToDelisle(double input)
    {
        return (80d - input) * 1.875d;
    }

    internal static double RéaumurToNewton(double input)
    {
        return input * 33d / 80d;
    }

    internal static double RéaumurToRéaumur(double input)
    {
        return input;
    }
}
