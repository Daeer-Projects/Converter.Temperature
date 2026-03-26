using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rømer;

/// <summary>
///     The Rømer float type.
/// </summary>
public sealed class RømerFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RømerFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RømerFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
