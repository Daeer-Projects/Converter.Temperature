namespace Converter.Temperature.Extensions.To.Réaumur;

using Converters.Réaumur;
using TemperatureTypes;
using Types.Réaumur;

/// <summary>
///     The to int extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Convert the <paramref name="input" /> to <see cref="Réaumur" />.
    /// </summary>
    /// <param name="input"> The temperature to convert. </param>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static int ToRéaumur(
        this RéaumurInt input)
    {
        return RéaumurIntConversions.RéaumurToRéaumur(input.Temperature);
    }
}
