﻿namespace Converter.Temperature.Types.Celsius;

using BaseTypes;

public sealed class CelsiusInt : IntBase
{
    public CelsiusInt(
        int temp)
    {
        Temperature = temp;
    }

    public override int Temperature { get; }
}
