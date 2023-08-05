namespace Converter.Temperature.Types.Kelvin;

using BaseTypes;

public sealed class KelvinString : StringBase
{
    public KelvinString(string temp)
    {
        Temperature = temp;
    }

    public override string Temperature { get; }
}