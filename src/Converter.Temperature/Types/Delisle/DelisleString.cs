namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

/// <summary>
///     The Delisle string type.
/// </summary>
public sealed class DelisleString : StringBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleString" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public DelisleString(
        string temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override string Temperature { get; }
}
