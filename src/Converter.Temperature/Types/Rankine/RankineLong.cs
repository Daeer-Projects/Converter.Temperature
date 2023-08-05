namespace Converter.Temperature.Types.Rankine;

using BaseTypes;

public sealed class RankineLong : LongBase
{
    public RankineLong(long temp)
    {
        Temperature = temp;
    }

    public override long Temperature { get; }
}