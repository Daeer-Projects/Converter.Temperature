namespace Converter.Temperature.Types.Réaumur;

using BaseTypes;

/// <summary>
///     The Réaumur double type.
/// </summary>
public sealed class RéaumurDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RéaumurDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public RéaumurDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override double Temperature { get; }
}
