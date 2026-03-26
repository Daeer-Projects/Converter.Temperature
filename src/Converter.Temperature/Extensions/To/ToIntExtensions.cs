using System;
using Converter.Temperature.BaseTypes;
using Converter.Temperature.Converters.Celsius;
using Converter.Temperature.Converters.Delisle;
using Converter.Temperature.Converters.Fahrenheit;
using Converter.Temperature.Converters.Gas;
using Converter.Temperature.Converters.Kelvin;
using Converter.Temperature.Converters.Newton;
using Converter.Temperature.Converters.Rankine;
using Converter.Temperature.Converters.Réaumur;
using Converter.Temperature.Converters.Rømer;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Delisle;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Newton;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Réaumur;
using Converter.Temperature.Types.Rømer;

namespace Converter.Temperature.Extensions.To;

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
    public static int To<TInput>(
        this IntBase input)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(TemperatureTypes.Celsius) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is KelvinInt castInput => KelvinIntConversions.KelvinToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is GasInt castInput => GasIntConversions.GasToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is RankineInt castInput => RankineIntConversions.RankineToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is RømerInt castInput => RømerIntConversions.RømerToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is DelisleInt castInput => DelisleIntConversions.DelisleToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is NewtonInt castInput => NewtonIntConversions.NewtonToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is KelvinInt castInput => KelvinIntConversions.KelvinToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is GasInt castInput => GasIntConversions.GasToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is RankineInt castInput => RankineIntConversions.RankineToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is RømerInt castInput => RømerIntConversions.RømerToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is DelisleInt castInput => DelisleIntConversions.DelisleToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is NewtonInt castInput => NewtonIntConversions.NewtonToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is KelvinInt castInput => KelvinIntConversions.KelvinToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is GasInt castInput => GasIntConversions.GasToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is RankineInt castInput => RankineIntConversions.RankineToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is RømerInt castInput => RømerIntConversions.RømerToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is DelisleInt castInput => DelisleIntConversions.DelisleToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is NewtonInt castInput => NewtonIntConversions.NewtonToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is KelvinInt castInput => KelvinIntConversions.KelvinToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is GasInt castInput => GasIntConversions.GasToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is RankineInt castInput => RankineIntConversions.RankineToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is RømerInt castInput => RømerIntConversions.RømerToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is DelisleInt castInput => DelisleIntConversions.DelisleToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is NewtonInt castInput => NewtonIntConversions.NewtonToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToGas(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is KelvinInt castInput => KelvinIntConversions.KelvinToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is GasInt castInput => GasIntConversions.GasToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is RankineInt castInput => RankineIntConversions.RankineToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is RømerInt castInput => RømerIntConversions.RømerToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is DelisleInt castInput => DelisleIntConversions.DelisleToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is NewtonInt castInput => NewtonIntConversions.NewtonToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is KelvinInt castInput => KelvinIntConversions.KelvinToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is GasInt castInput => GasIntConversions.GasToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is RankineInt castInput => RankineIntConversions.RankineToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is RømerInt castInput => RømerIntConversions.RømerToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is DelisleInt castInput => DelisleIntConversions.DelisleToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is NewtonInt castInput => NewtonIntConversions.NewtonToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is KelvinInt castInput => KelvinIntConversions.KelvinToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is GasInt castInput => GasIntConversions.GasToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is RankineInt castInput => RankineIntConversions.RankineToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is RømerInt castInput => RømerIntConversions.RømerToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is DelisleInt castInput => DelisleIntConversions.DelisleToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is NewtonInt castInput => NewtonIntConversions.NewtonToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is KelvinInt castInput => KelvinIntConversions.KelvinToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is GasInt castInput => GasIntConversions.GasToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is RankineInt castInput => RankineIntConversions.RankineToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is RømerInt castInput => RømerIntConversions.RømerToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is DelisleInt castInput => DelisleIntConversions.DelisleToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is NewtonInt castInput => NewtonIntConversions.NewtonToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is CelsiusInt castInput => CelsiusIntConversions.CelsiusToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is FahrenheitInt castInput => FahrenheitIntConversions.FahrenheitToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is KelvinInt castInput => KelvinIntConversions.KelvinToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is GasInt castInput => GasIntConversions.GasToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is RankineInt castInput => RankineIntConversions.RankineToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is RømerInt castInput => RømerIntConversions.RømerToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is DelisleInt castInput => DelisleIntConversions.DelisleToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is NewtonInt castInput => NewtonIntConversions.NewtonToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is RéaumurInt castInput => RéaumurIntConversions.RéaumurToRéaumur(castInput.Temperature),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
