using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Kelvin;

/// <summary>
///     The Kelvin int type.
/// </summary>
public sealed class KelvinInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="KelvinInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public KelvinInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
