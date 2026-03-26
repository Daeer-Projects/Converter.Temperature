using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Types.Delisle;

/// <summary>
///     The Delisle float type.
/// </summary>
public sealed class DelisleFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature value. </param>
    public DelisleFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public override float Temperature { get; }
}
