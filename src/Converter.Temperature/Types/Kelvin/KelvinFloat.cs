using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Kelvin;

/// <summary>
///     The Kelvin float type.
/// </summary>
public sealed class KelvinFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="KelvinFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public KelvinFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
