using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Newton;

/// <summary>
///     The Newton int type.
/// </summary>
public sealed class NewtonInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public NewtonInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
