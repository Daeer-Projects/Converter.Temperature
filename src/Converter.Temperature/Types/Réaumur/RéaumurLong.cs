using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Réaumur;

/// <summary>
///     The Réaumur long type.
/// </summary>
public sealed class RéaumurLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RéaumurLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
