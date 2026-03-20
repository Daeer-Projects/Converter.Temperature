using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Extensions.To.Newton;

/// <summary>
///     The to newton long extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the input to Newton.
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static long ToNewton(
        this LongBase input)
    {
        return input.To<TemperatureTypes.Newton>();
    }
}
