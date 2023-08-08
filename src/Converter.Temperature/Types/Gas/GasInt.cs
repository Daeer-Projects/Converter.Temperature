namespace Converter.Temperature.Types.Gas;

using BaseTypes;

public sealed class GasInt : IntBase
{
    public GasInt(
        int temp)
    {
        Temperature = temp;
    }

    public override int Temperature { get; }
}
