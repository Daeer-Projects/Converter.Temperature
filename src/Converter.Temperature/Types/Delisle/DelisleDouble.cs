namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

public sealed class DelisleDouble : DoubleBase
{
    public DelisleDouble(
        double temp)
    {
        Temperature = temp;
    }

    public override double Temperature { get; }
}
