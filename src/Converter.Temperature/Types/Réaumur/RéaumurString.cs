using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Réaumur;

/// <summary>
///     The Réaumur string type.
/// </summary>
public sealed class RéaumurString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RéaumurString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
