using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rankine;

/// <summary>
///     The Rankine long type.
/// </summary>
public sealed class RankineLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RankineLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RankineLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
