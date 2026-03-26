using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Rømer;

/// <summary>
///     The Rømer double type.
/// </summary>
public sealed class RømerDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="RømerDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public RømerDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
