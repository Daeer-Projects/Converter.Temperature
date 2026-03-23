using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Kelvin;

/// <summary>
///     The Kelvin string type.
/// </summary>
public sealed class KelvinString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="KelvinString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public KelvinString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
