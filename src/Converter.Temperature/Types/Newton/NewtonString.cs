namespace Converter.Temperature.Types.Newton;

using BaseTypes;

/// <summary>
///     The Newton string type.
/// </summary>
public sealed class NewtonString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public NewtonString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override string Temperature { get; }
}
