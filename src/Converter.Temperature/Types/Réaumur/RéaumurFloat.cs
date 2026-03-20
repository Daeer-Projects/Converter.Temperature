namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

public sealed class RéaumurFloat : FloatBase
{
    public RéaumurFloat(
        float temp)
    {
        Temperature = temp;
    }

    public override float Temperature { get; }
}
