using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Gas;

/// <summary>
///     The Gas string type.
/// </summary>
public sealed class GasString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GasString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public GasString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
