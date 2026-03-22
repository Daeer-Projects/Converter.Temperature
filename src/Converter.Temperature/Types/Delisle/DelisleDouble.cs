using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Delisle;

/// <summary>
///     The Delisle double type.
/// </summary>
public sealed class DelisleDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public DelisleDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
