namespace Converter.Temperature.Extensions.To.Helpers;

using System;

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
}
