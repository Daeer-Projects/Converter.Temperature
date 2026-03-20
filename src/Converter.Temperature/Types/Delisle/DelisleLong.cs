namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

public sealed class DelisleLong : LongBase
{
    public DelisleLong(
        long temp)
    {
        Temperature = temp;
    }

    public override long Temperature { get; }
}
