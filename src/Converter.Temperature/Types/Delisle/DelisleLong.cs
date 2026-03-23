using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Delisle;

/// <summary>
///     The Delisle long type.
/// </summary>
public sealed class DelisleLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public DelisleLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
