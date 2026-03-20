namespace Converter.Temperature.Types.Newton;

using BaseTypes;

public sealed class NewtonDouble : DoubleBase
{
    public NewtonDouble(
        double temp)
    {
        Temperature = temp;
    }

    public override double Temperature { get; }
}
