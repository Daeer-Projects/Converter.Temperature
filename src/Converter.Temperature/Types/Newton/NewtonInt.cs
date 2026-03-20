namespace Converter.Temperature.Types.Newton;

using BaseTypes;

public sealed class NewtonInt : IntBase
{
    public NewtonInt(
        int temp)
    {
        Temperature = temp;
    }

    public override int Temperature { get; }
}
