using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Gas;

/// <summary>
///     The Gas long type.
/// </summary>
public sealed class GasLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GasLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public GasLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
