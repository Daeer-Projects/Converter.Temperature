using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rankine;

/// <summary>
///     The Rankine int type.
/// </summary>
public sealed class RankineInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RankineInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RankineInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
