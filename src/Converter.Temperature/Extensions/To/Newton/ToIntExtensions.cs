using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Extensions.To.Newton;

/// <summary>
///     The to newton int extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the input to Newton.
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static int ToNewton(
        this IntBase input)
    {
        return input.To<TemperatureTypes.Newton>();
    }
}
