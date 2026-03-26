using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Réaumur;

/// <summary>
///     The Réaumur double type.
/// </summary>
public sealed class RéaumurDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RéaumurDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
