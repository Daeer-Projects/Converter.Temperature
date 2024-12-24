namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

public sealed class CelsiusDouble : DoubleBase
{
    public CelsiusDouble(
        double temp)
    {
        Temperature = temp;
    }

    public override double Temperature { get; }
}
