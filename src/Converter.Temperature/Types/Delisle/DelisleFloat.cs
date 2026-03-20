namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

public sealed class DelisleFloat : FloatBase
{
    public DelisleFloat(
        float temp)
    {
        Temperature = temp;
    }

    public override float Temperature { get; }
}
