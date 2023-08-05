namespace Converter.Temperature.Types.Rømer;

using BaseTypes;

public sealed class RømerInt : IntBase
{
    public RømerInt(
        int temp)
    {
        Temperature = temp;
    }

    public override int Temperature { get; }
}
