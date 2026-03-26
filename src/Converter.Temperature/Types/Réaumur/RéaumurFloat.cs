using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Réaumur;

/// <summary>
///     The Réaumur float type.
/// </summary>
public sealed class RéaumurFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RéaumurFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
