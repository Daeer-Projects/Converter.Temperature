namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

public sealed class RéaumurString : StringBase
{
    public RéaumurString(
        string temp)
    {
        Temperature = temp;
    }

    public override string Temperature { get; }
}
