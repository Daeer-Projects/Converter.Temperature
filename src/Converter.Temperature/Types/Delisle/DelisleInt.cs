using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Delisle;

/// <summary>
///     The Delisle int type.
/// </summary>
public sealed class DelisleInt : IntBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleInt" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public DelisleInt(
        int temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override int Temperature { get; }
}
