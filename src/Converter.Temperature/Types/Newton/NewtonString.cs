namespace Converter.Temperature.Types.Newton;

using BaseTypes;

public sealed class NewtonString : StringBase
{
    public NewtonString(
        string temp)
    {
        Temperature = temp;
    }

    public override string Temperature { get; }
}
