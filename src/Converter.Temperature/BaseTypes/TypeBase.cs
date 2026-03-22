namespace Converter.Temperature.BaseTypes;

/// <summary>
///     The type base for the temperature types.
/// </summary>
/// <typeparam name="T"> The type of the temperature. </typeparam>
public abstract class TypeBase<T>
{
    /// <summary>
    ///     Gets the temperature value.
    /// </summary>
    public abstract T Temperature { get; }
}
