using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Kelvin;

/// <summary>
///     The Kelvin long type.
/// </summary>
public sealed class KelvinLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="KelvinLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public KelvinLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
