using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rømer;

/// <summary>
///     The Rømer string type.
/// </summary>
public sealed class RømerString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RømerString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RømerString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
