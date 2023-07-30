namespace Converter.Temperature.Extensions.To.Helpers;

using System;
using System.Globalization;

internal static class ToExtensionHelpers
{
    internal static double Rounder(
        double input,
        int fractionalCount = -1)
    {
        return fractionalCount < 0 ? input : Math.Round(input, fractionalCount);
    }

    internal static float Rounder(
        float input,
        int fractionalCount = -1)
    {
        if (fractionalCount < 0)
        {
            return input;
        }

        return (float)Math.Round(input, fractionalCount);
    }

    internal static string Parser(
        string temp,
        Func<double, double> methodToParse,
        int fractionalCount)
    {
        string convertedTemp = string.Empty;
        if (double.TryParse(temp.AsSpan(), out double inputAsDouble))
            convertedTemp = Rounder(methodToParse(inputAsDouble), fractionalCount)
                .ToString(CultureInfo.InvariantCulture);

        return convertedTemp;
    }
}
