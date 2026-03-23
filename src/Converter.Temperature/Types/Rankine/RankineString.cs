using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rankine;

/// <summary>
///     The Rankine string type.
/// </summary>
public sealed class RankineString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RankineString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RankineString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
