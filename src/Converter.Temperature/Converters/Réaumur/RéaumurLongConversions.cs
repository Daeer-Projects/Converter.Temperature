using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Réaumur;

internal static class RéaumurLongConversions
{
    internal static long RéaumurToCelsius(long input)
    {
        double convertedTemp = input * 5d / 4d;
        return (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    internal static long RéaumurToFahrenheit(long input)
    {
        double convertedTemp = (input * 9d / 4d) + 32d;
        return (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    internal static long RéaumurToKelvin(long input)
    {
        double convertedTemp = (input * 5d / 4d) + 273.15d;
        return (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    internal static long RéaumurToGas(long input)
    {
        long celsiusResult = RéaumurToCelsius(input);
        return CelsiusLongConversions.CelsiusToGas(celsiusResult);
    }

    internal static long RéaumurToRankine(long input)
    {
        double convertedTemp = (input * 9d / 4d) + 491.67d;
        return (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    internal static long RéaumurToRømer(long input)
    {
        double convertedTemp = input * 21d / 32d + 7.5d;
        return (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    internal static long RéaumurToDelisle(long input)
    {
        double convertedTemp = (80d - input) * 15d / 8d;
        return (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    internal static long RéaumurToNewton(long input)
    {
        double convertedTemp = input * 33d / 80d;
        return (long)Math.Round(convertedTemp, 0, MidpointRounding.AwayFromZero);
    }

    internal static long RéaumurToRéaumur(long input)
    {
        return input;
    }
}
