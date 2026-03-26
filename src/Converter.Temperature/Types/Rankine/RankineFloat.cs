using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rankine;

/// <summary>
///     The Rankine float type.
/// </summary>
public sealed class RankineFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RankineFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RankineFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
