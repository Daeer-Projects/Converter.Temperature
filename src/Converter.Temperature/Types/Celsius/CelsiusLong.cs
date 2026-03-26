using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Celsius;

/// <summary>
///     The Celsius long type.
/// </summary>
public sealed class CelsiusLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CelsiusLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public CelsiusLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
