namespace Converter.Temperature.Types.Newton;

using BaseTypes;

public sealed class NewtonLong : LongBase
{
    public NewtonLong(
        long temp)
    {
        Temperature = temp;
    }

    public override long Temperature { get; }
}
