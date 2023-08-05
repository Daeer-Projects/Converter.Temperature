namespace Converter.Temperature.Types.Rømer;

using BaseTypes;

public sealed class RømerLong : LongBase
{
    public RømerLong(
        long temp)
    {
        Temperature = temp;
    }

    public override long Temperature { get; }
}
