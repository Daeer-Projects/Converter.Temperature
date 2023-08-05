namespace Converter.Temperature.Types.Gas;

using BaseTypes;

public sealed class GasLong : LongBase
{
    public GasLong(
        long temp)
    {
        Temperature = temp;
    }

    public override long Temperature { get; }
}
