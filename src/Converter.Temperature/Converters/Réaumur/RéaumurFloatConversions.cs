using System;
using Converter.Temperature.Converters.Celsius;

namespace Converter.Temperature.Converters.Réaumur;

internal static class RéaumurFloatConversions
{
    internal static float RéaumurToCelsius(float input)
    {
        return input * 5f / 4f;
    }

    internal static float RéaumurToFahrenheit(float input)
    {
        return (input * 9f / 4f) + 32f;
    }

    internal static float RéaumurToKelvin(float input)
    {
        return (input * 5f / 4f) + 273.15f;
    }

    internal static float RéaumurToGas(float input)
    {
        float celsiusResult = RéaumurToCelsius(input);
        return CelsiusFloatConversions.CelsiusToGas(celsiusResult);
    }

    internal static float RéaumurToRankine(float input)
    {
        return (input * 9f / 4f) + 491.67f;
    }

    internal static float RéaumurToRømer(float input)
    {
        return input * 21f / 32f + 7.5f;
    }

    internal static float RéaumurToDelisle(float input)
    {
        return (80f - input) * 15f / 8f;
    }

    internal static float RéaumurToNewton(float input)
    {
        return input * 33f / 80f;
    }

    internal static float RéaumurToRéaumur(float input)
    {
        return input;
    }
}
