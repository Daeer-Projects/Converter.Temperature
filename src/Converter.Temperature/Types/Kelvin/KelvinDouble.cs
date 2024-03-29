﻿namespace Converter.Temperature.Types.Kelvin;

using BaseTypes;

public sealed class KelvinDouble : DoubleBase
{
    public KelvinDouble(
        double temp)
    {
        Temperature = temp;
    }

    public override double Temperature { get; }
}
