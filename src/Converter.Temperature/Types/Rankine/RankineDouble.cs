using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rankine;

/// <summary>
///     The Rankine double type.
/// </summary>
public sealed class RankineDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RankineDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RankineDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
