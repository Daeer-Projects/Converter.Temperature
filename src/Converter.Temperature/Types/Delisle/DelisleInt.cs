namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

/// <summary>
///     The Delisle int type.
/// </summary>
public sealed class DelisleInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public DelisleInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override int Temperature { get; }
}
