﻿namespace Converter.Temperature.Types.Fahrenheit;

using BaseTypes;

public sealed class FahrenheitString : StringBase
{
    public FahrenheitString(
        string temp)
    {
        Temperature = temp;
    }

    public string Temperature { get; }
}
