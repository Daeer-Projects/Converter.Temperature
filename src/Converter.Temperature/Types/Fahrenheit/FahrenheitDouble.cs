namespace Converter.Temperature.Types.Fahrenheit;

using BaseTypes;

public sealed class FahrenheitDouble : DoubleBase
{
    public FahrenheitDouble(
        double temp)
    {
        Temperature = temp;
    }

    public double Temperature { get; }
}
