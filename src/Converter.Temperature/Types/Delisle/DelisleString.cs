using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Delisle;

/// <summary>
///     The Delisle string type.
/// </summary>
public sealed class DelisleString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public DelisleString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
