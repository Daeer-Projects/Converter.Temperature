namespace Converter.Temperature.Types.Newton;

using BaseTypes;

/// <summary>
///     The Newton int type.
/// </summary>
public sealed class NewtonInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public NewtonInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override int Temperature { get; }
}
