namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

public sealed class RéaumurLong : LongBase
{
    public RéaumurLong(
        long temp)
    {
        Temperature = temp;
    }

    public override long Temperature { get; }
}
