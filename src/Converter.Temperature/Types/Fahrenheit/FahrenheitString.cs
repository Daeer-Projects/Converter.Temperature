using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Fahrenheit;

/// <summary>
///     The Fahrenheit string type.
/// </summary>
public sealed class FahrenheitString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FahrenheitString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public FahrenheitString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override string Temperature { get; }
}
