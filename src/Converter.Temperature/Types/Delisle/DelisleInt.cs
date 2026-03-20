namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

public sealed class DelisleInt : IntBase
{
    public DelisleInt(
        int temp)
    {
        Temperature = temp;
    }

    public override int Temperature { get; }
}
