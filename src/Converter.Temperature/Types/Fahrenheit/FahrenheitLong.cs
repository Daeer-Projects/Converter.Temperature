using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Fahrenheit;

/// <summary>
///     The Fahrenheit long type.
/// </summary>
public sealed class FahrenheitLong : LongBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FahrenheitLong" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public FahrenheitLong(
        long temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override long Temperature { get; }
}
