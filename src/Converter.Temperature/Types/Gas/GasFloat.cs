using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Gas;

/// <summary>
///     The Gas float type.
/// </summary>
public sealed class GasFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GasFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public GasFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
