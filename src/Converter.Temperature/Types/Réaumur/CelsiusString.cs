namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

public sealed class CelsiusString : StringBase
{
    public CelsiusString(
        string temp)
    {
        Temperature = temp;
    }

    public override string Temperature { get; }
}
