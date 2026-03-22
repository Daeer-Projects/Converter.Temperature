namespace Converter.Temperature.Types.Delisle;

using BaseTypes;

/// <summary>
///     The Delisle float type.
/// </summary>
public sealed class DelisleFloat : FloatBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DelisleFloat" /> class.
    /// </summary>
    /// <param name="temp"> The temperature to initialize with. </param>
    public DelisleFloat(
        float temp)
    {
        Temperature = temp;
    }

    /// <summary>
    ///     Gets the temperature.
    /// </summary>
    public override float Temperature { get; }
}
