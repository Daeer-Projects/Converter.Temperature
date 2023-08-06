﻿namespace Converter.Temperature.Types.Celsius;

using BaseTypes;

public sealed class CelsiusString : StringBase
{
    public CelsiusString(
        string temp)
    {
        Temperature = temp;
    }

    public string Temperature { get; }
}
