namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

/// <summary>
///     The Réaumur string type.
/// </summary>
public sealed class RéaumurString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public RéaumurString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override string Temperature { get; }
}
