using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Newton;

/// <summary>
///     The Newton double type.
/// </summary>
public sealed class NewtonDouble : DoubleBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonDouble" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public NewtonDouble(
        double temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override double Temperature { get; }
}
