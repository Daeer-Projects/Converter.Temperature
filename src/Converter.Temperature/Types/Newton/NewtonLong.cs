using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Newton;

/// <summary>
///     The Newton long type.
/// </summary>
public sealed class NewtonLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public NewtonLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
