﻿namespace Converter.Temperature.Types.Rømer;

using BaseTypes;

public sealed class RømerFloat : FloatBase
{
    public RømerFloat(float temp)
    {
        Temperature = temp;
    }

    public float Temperature { get; }
}