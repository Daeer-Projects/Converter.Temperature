using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Gas;

/// <summary>
///     The Gas double type.
/// </summary>
public sealed class GasDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GasDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public GasDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
