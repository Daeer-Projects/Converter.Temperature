namespace Converter.Temperature.Extensions.To.Réaumur;

using Converters.Réaumur;
using Helpers;
using TemperatureTypes;
using Types.Réaumur;

/// <summary>
///     The to float extensions.
/// </summary>
public static class ToFloatExtensions
{
    /// <summary>
    ///     Convert the <paramref name="input" /> to <see cref="Réaumur" />.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <param name="fractionalCount"> The number of fractional digits in the return value. </param>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static float ToRéaumur(
        this RéaumurFloat input,
        int fractionalCount = -1)
    {
        return ToExtensionHelpers.Rounder(
            RéaumurFloatConversions.RéaumurToRéaumur(input.Temperature),
            fractionalCount);
    }
}
