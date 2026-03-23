using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Kelvin;

/// <summary>
///     The Kelvin double type.
/// </summary>
public sealed class KelvinDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="KelvinDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public KelvinDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
