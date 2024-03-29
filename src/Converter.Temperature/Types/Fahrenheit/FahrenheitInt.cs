﻿namespace Converter.Temperature.Types.Fahrenheit;

using BaseTypes;

public sealed class FahrenheitInt : IntBase
{
    public FahrenheitInt(
        int temp)
    {
        Temperature = temp;
    }

    public override int Temperature { get; }
}
