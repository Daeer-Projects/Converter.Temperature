namespace Converter.Temperature.Extensions.To;

using System;
using BaseTypes;
using Converter.Temperature.Converters.Rømer;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="long" /> extensions.
/// </summary>
public static class ToLongExtensions
{
    /// <summary>
    ///     Converts the Long input to the correct Long value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static long To<TInput>(
        this LongBase input)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToCelsius(castInput.Temperature),
            nameof(Celsius) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToCelsius(
                castInput.Temperature),
            nameof(Celsius) when input is KelvinLong castInput => KelvinLongConversions.KelvinToCelsius(castInput.Temperature),
            nameof(Celsius) when input is GasLong castInput => GasLongConversions.GasToCelsius(castInput.Temperature),
            nameof(Celsius) when input is RankineLong castInput => RankineLongConversions.RankineToCelsius(castInput.Temperature),
            nameof(Celsius) when input is RømerLong castInput => RømerLongConversions.RømerToCelsius(castInput.Temperature),
            nameof(Fahrenheit) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToFahrenheit(
                castInput.Temperature),
            nameof(Fahrenheit) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToFahrenheit(
                castInput.Temperature),
            nameof(Fahrenheit) when input is KelvinLong castInput => KelvinLongConversions.KelvinToFahrenheit(
                castInput.Temperature),
            nameof(Fahrenheit) when input is GasLong castInput => GasLongConversions.GasToFahrenheit(castInput.Temperature),
            nameof(Fahrenheit) when input is RankineLong castInput => RankineLongConversions.RankineToFahrenheit(
                castInput.Temperature),
            nameof(Fahrenheit) when input is RømerLong castInput => RømerLongConversions.RømerToFahrenheit(
                castInput.Temperature),
            nameof(Kelvin) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToKelvin(castInput.Temperature),
            nameof(Kelvin) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToKelvin(
                castInput.Temperature),
            nameof(Kelvin) when input is KelvinLong castInput => KelvinLongConversions.KelvinToKelvin(castInput.Temperature),
            nameof(Kelvin) when input is GasLong castInput => GasLongConversions.GasToKelvin(castInput.Temperature),
            nameof(Kelvin) when input is RankineLong castInput => RankineLongConversions.RankineToKelvin(castInput.Temperature),
            nameof(Kelvin) when input is RømerLong castInput => RømerLongConversions.RømerToKelvin(castInput.Temperature),
            nameof(Gas) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToGas(castInput.Temperature),
            nameof(Gas) when input is FahrenheitLong castInput =>
                FahrenheitLongConversions.FahrenheitToGas(castInput.Temperature),
            nameof(Gas) when input is KelvinLong castInput => KelvinLongConversions.KelvinToGas(castInput.Temperature),
            nameof(Gas) when input is GasLong castInput => GasLongConversions.GasToGas(castInput.Temperature),
            nameof(Gas) when input is RankineLong castInput => RankineLongConversions.RankineToGas(castInput.Temperature),
            nameof(Gas) when input is RømerLong castInput => RømerLongConversions.RømerToGas(castInput.Temperature),
            nameof(Rankine) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToRankine(castInput.Temperature),
            nameof(Rankine) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToRankine(
                castInput.Temperature),
            nameof(Rankine) when input is KelvinLong castInput => KelvinLongConversions.KelvinToRankine(castInput.Temperature),
            nameof(Rankine) when input is GasLong castInput => GasLongConversions.GasToRankine(castInput.Temperature),
            nameof(Rankine) when input is RankineLong castInput => RankineLongConversions.RankineToRankine(castInput.Temperature),
            nameof(Rankine) when input is RømerLong castInput => RømerLongConversions.RømerToRankine(castInput.Temperature),
            nameof(Rømer) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToRømer(castInput.Temperature),
            nameof(Rømer) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToRømer(
                castInput.Temperature),
            nameof(Rømer) when input is KelvinLong castInput => KelvinLongConversions.KelvinToRømer(castInput.Temperature),
            nameof(Rømer) when input is GasLong castInput => GasLongConversions.GasToRømer(castInput.Temperature),
            nameof(Rømer) when input is RankineLong castInput => RankineLongConversions.RankineToRømer(castInput.Temperature),
            nameof(Rømer) when input is RømerLong castInput => RømerLongConversions.RømerToRømer(castInput.Temperature),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
