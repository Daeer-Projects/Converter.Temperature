namespace Converter.Temperature.Types.Celsius;

using BaseTypes;

public sealed class CelsiusFloat : FloatBase
{
    public CelsiusFloat(
        float temp)
    {
        Temperature = temp;
    }

    public float Temperature { get; }
}
