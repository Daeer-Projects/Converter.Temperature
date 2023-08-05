namespace Converter.Temperature.Types.Rømer;

using BaseTypes;

public sealed class RømerString : StringBase
{
    public RømerString(
        string temp)
    {
        Temperature = temp;
    }

    public override string Temperature { get; }
}
