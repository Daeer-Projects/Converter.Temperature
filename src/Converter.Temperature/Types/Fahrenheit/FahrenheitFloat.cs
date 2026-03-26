using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Fahrenheit;

/// <summary>
///     The Fahrenheit float type.
/// </summary>
public sealed class FahrenheitFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FahrenheitFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public FahrenheitFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
