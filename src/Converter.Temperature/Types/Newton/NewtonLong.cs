namespace Converter.Temperature.Types.Newton;

using BaseTypes;

/// <summary>
///     The Newton long type.
/// </summary>
public sealed class NewtonLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public NewtonLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override long Temperature { get; }
}
