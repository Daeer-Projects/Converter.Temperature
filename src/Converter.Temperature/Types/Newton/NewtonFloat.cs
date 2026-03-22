namespace Converter.Temperature.Types.Newton;

using BaseTypes;

/// <summary>
///     The Newton float type.
/// </summary>
public sealed class NewtonFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public NewtonFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override float Temperature { get; }
}
