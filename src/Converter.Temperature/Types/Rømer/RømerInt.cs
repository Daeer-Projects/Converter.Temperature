using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rømer;

/// <summary>
///     The Rømer int type.
/// </summary>
public sealed class RømerInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RømerInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RømerInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
