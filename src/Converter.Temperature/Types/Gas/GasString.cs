﻿namespace Converter.Temperature.Types.Gas;

using BaseTypes;

public sealed class GasString : StringBase
{
    public GasString(
        string temp)
    {
        Temperature = temp;
    }

    public override string Temperature { get; }
}
