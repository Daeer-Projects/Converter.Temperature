using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Celsius;

/// <summary>
///     The Celsius string type.
/// </summary>
public sealed class CelsiusString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CelsiusString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public CelsiusString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
