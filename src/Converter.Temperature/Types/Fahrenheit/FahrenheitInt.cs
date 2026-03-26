using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Fahrenheit;

/// <summary>
///     The Fahrenheit int type.
/// </summary>
public sealed class FahrenheitInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FahrenheitInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public FahrenheitInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
