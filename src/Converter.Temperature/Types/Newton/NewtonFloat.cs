using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Newton;

/// <summary>
///     The Newton float type.
/// </summary>
public sealed class NewtonFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public NewtonFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
