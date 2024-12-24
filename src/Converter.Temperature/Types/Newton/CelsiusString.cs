namespace Converter.Temperature.Types.Newton;

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
