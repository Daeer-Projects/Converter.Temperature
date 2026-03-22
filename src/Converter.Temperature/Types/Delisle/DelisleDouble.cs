namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

/// <summary>
///     The Delisle double type.
/// </summary>
public sealed class DelisleDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public DelisleDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override double Temperature { get; }
}
