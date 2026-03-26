using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Fahrenheit;

/// <summary>
///     The Fahrenheit double type.
/// </summary>
public sealed class FahrenheitDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FahrenheitDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public FahrenheitDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
