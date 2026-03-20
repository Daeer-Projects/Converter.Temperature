namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

public sealed class DelisleString : StringBase
{
    public DelisleString(
        string temp)
    {
        Temperature = temp;
    }

    public override string Temperature { get; }
}
