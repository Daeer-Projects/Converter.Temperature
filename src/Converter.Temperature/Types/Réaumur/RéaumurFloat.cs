namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

/// <summary>
///     The Réaumur float type.
/// </summary>
public sealed class RéaumurFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public RéaumurFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override float Temperature { get; }
}
