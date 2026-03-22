using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Celsius;

/// <summary>
///     The Celsius double type.
/// </summary>
public sealed class CelsiusDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CelsiusDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public CelsiusDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
