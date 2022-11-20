namespace Converter.Temperature.Types.Fahrenheit;

using BaseTypes;

public sealed class FahrenheitFloat : FloatBase
{
    public FahrenheitFloat(float temp)
    {
        Temperature = temp;
    }

    public float Temperature { get; }
}