namespace Converter.Temperature.Types.Réaumur;

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
