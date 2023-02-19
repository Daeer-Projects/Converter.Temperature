namespace Converter.Temperature.Types.Rømer;

using BaseTypes;

public sealed class RømerDouble : DoubleBase
{
    public RømerDouble(double temp)
    {
        Temperature = temp;
    }

    public double Temperature { get; }
}