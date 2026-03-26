using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rømer;

/// <summary>
///     The Rømer long type.
/// </summary>
public sealed class RømerLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RømerLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RømerLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
