using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Gas;

/// <summary>
///     The Gas int type.
/// </summary>
public sealed class GasInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GasInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public GasInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
