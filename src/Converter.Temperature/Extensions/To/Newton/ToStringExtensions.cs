using Converter.Temperature.BaseTypes;

namespace Converter.Temperature.Extensions.To.Newton;

/// <summary>
///     The to newton string extensions.
/// </summary>
public static class ToStringExtensions
{
    /// <summary>
    ///     Converts the input to Newton.
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static string ToNewton(
        this StringBase input,
        int fractionalCount = -1)
    {
        return input.To<TemperatureTypes.Newton>(fractionalCount);
    }
}
