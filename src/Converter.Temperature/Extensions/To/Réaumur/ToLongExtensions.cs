namespace Converter.Temperature.Extensions.To.Réaumur;

using Converters.Réaumur;
using TemperatureTypes;
using Types.Réaumur;

/// <summary>
///     The to long extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Convert the <paramref name="input" /> to <see cref="Réaumur" />.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static long ToRéaumur(
        this RéaumurLong input)
    {
        return RéaumurLongConversions.RéaumurToRéaumur(input.Temperature);
    }
}
