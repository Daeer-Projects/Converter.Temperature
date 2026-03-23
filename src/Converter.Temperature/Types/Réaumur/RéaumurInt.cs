using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Réaumur;

/// <summary>
///     The Réaumur int type.
/// </summary>
public sealed class RéaumurInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RéaumurInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
