namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

/// <summary>
///     The Réaumur long type.
/// </summary>
public sealed class RéaumurLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public RéaumurLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override long Temperature { get; }
}
