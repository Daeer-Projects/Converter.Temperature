namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

/// <summary>
///     The Delisle long type.
/// </summary>
public sealed class DelisleLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public DelisleLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override long Temperature { get; }
}
