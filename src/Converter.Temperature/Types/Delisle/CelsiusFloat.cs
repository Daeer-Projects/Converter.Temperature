namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

public sealed class CelsiusFloat : FloatBase
{
    public CelsiusFloat(
        float temp)
    {
        Temperature = temp;
    }

    public override float Temperature { get; }
}
