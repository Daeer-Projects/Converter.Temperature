﻿namespace Converter.Temperature.Types.Celsius
{
    using BaseTypes;

    public sealed class CelsiusLong : LongBase
    {
        public CelsiusLong(long temp)
        {
            Temperature = temp;
        }

        public long Temperature { get; }
    }
}
