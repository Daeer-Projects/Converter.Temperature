using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Celsius;

/// <summary>
///     The Celsius float type.
/// </summary>
public sealed class CelsiusFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CelsiusFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public CelsiusFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
