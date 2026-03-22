namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

/// <summary>
///     The Réaumur int type.
/// </summary>
public sealed class RéaumurInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public RéaumurInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override int Temperature { get; }
}
