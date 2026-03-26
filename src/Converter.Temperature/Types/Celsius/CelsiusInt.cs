using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Celsius;

/// <summary>
///     The Celsius int type.
/// </summary>
public sealed class CelsiusInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CelsiusInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public CelsiusInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
