namespace Converter.Temperature.Extensions.To;

using System;
using BaseTypes;
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

/// <summary>
///     The to <see langword="int" /> extensions.
/// </summary>
public static class ToIntExtensions
{
    /// <summary>
    ///     Converts the Int input to the correct int value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static int To<TInput>(this IntBase input)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToCelsius(castInput.Temperature),
            nameof(Celsius) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToCelsius(
                castInput.Temperature),
            nameof(Celsius) when input is KelvinInt castInput => KelvinIntConversions.KelvinToCelsius(castInput.Temperature),
            nameof(Celsius) when input is GasInt castInput => GasIntConversions.GasToCelsius(castInput.Temperature),
            nameof(Celsius) when input is RankineInt castInput => RankineIntConversions.RankineToCelsius(castInput.Temperature),
            nameof(Fahrenheit) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToFahrenheit(
                castInput.Temperature),
            nameof(Fahrenheit) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToFahrenheit(
                castInput.Temperature),
            nameof(Fahrenheit) when input is KelvinInt castInput =>
                KelvinIntConversions.KelvinToFahrenheit(castInput.Temperature),
            nameof(Fahrenheit) when input is GasInt castInput => GasIntConversions.GasToFahrenheit(castInput.Temperature),
            nameof(Fahrenheit) when input is RankineInt castInput => RankineIntConversions.RankineToFahrenheit(
                castInput.Temperature),
            nameof(Kelvin) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToKelvin(castInput.Temperature),
            nameof(Kelvin) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToKelvin(
                castInput.Temperature),
            nameof(Kelvin) when input is KelvinInt castInput => KelvinIntConversions.KelvinToKelvin(castInput.Temperature),
            nameof(Kelvin) when input is GasInt castInput => GasIntConversions.GasToKelvin(castInput.Temperature),
            nameof(Kelvin) when input is RankineInt castInput => RankineIntConversions.RankineToKelvin(castInput.Temperature),
            nameof(Gas) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToGas(castInput.Temperature),
            nameof(Gas) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToGas(castInput.Temperature),
            nameof(Gas) when input is KelvinInt castInput => KelvinIntConversions.KelvinToGas(castInput.Temperature),
            nameof(Gas) when input is GasInt castInput => GasIntConversions.GasToGas(castInput.Temperature),
            nameof(Gas) when input is RankineInt castInput => RankineIntConversions.RankineToGas(castInput.Temperature),
            nameof(Rankine) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToRankine(castInput.Temperature),
            nameof(Rankine) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToRankine(
                castInput.Temperature),
            nameof(Rankine) when input is KelvinInt castInput => KelvinIntConversions.KelvinToRankine(castInput.Temperature),
            nameof(Rankine) when input is GasInt castInput => GasIntConversions.GasToRankine(castInput.Temperature),
            nameof(Rankine) when input is RankineInt castInput => RankineIntConversions.RankineToRankine(castInput.Temperature),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}