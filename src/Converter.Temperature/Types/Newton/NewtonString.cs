using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Newton;

/// <summary>
///     The Newton string type.
/// </summary>
public sealed class NewtonString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NewtonString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public NewtonString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
