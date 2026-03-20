namespace Converter.Temperature.Types.Newton;

using BaseTypes;

public sealed class NewtonFloat : FloatBase
{
    public NewtonFloat(
        float temp)
    {
        Temperature = temp;
    }

    public override float Temperature { get; }
}
