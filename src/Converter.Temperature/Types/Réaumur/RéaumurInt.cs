namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

public sealed class RéaumurInt : IntBase
{
    public RéaumurInt(
        int temp)
    {
        Temperature = temp;
    }

    public override int Temperature { get; }
}
