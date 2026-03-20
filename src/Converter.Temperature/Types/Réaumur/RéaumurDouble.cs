namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

public sealed class RéaumurDouble : DoubleBase
{
    public RéaumurDouble(
        double temp)
    {
        Temperature = temp;
    }

    public override double Temperature { get; }
}
