namespace Converter.Temperature.Types.Newton;

using BaseTypes;

/// <summary>
///     The Newton double type.
/// </summary>
public sealed class NewtonDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public NewtonDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override double Temperature { get; }
}
