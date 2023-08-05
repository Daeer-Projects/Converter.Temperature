namespace Converter.Temperature.Types.Gas;

using BaseTypes;

public sealed class GasDouble : DoubleBase
{
    public GasDouble(double temp)
    {
        Temperature = temp;
    }

    public override double Temperature { get; }
}