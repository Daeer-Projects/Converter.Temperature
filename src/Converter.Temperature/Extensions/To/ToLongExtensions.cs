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
            nameof(TemperatureTypes.Celsius) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is KelvinLong castInput => KelvinLongConversions.KelvinToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is GasLong castInput => GasLongConversions.GasToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is RankineLong castInput => RankineLongConversions.RankineToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is RømerLong castInput => RømerLongConversions.RømerToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is DelisleLong castInput => DelisleLongConversions.DelisleToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is NewtonLong castInput => NewtonLongConversions.NewtonToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Celsius) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToCelsius(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is KelvinLong castInput => KelvinLongConversions.KelvinToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is GasLong castInput => GasLongConversions.GasToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is RankineLong castInput => RankineLongConversions.RankineToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is RømerLong castInput => RømerLongConversions.RømerToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is DelisleLong castInput => DelisleLongConversions.DelisleToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is NewtonLong castInput => NewtonLongConversions.NewtonToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Fahrenheit) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToFahrenheit(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is KelvinLong castInput => KelvinLongConversions.KelvinToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is GasLong castInput => GasLongConversions.GasToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is RankineLong castInput => RankineLongConversions.RankineToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is RømerLong castInput => RømerLongConversions.RømerToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is DelisleLong castInput => DelisleLongConversions.DelisleToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is NewtonLong castInput => NewtonLongConversions.NewtonToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Kelvin) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToKelvin(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is KelvinLong castInput => KelvinLongConversions.KelvinToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is GasLong castInput => GasLongConversions.GasToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is RankineLong castInput => RankineLongConversions.RankineToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is RømerLong castInput => RømerLongConversions.RømerToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is DelisleLong castInput => DelisleLongConversions.DelisleToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is NewtonLong castInput => NewtonLongConversions.NewtonToGas(castInput.Temperature),
            nameof(TemperatureTypes.Gas) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToGas(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is KelvinLong castInput => KelvinLongConversions.KelvinToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is GasLong castInput => GasLongConversions.GasToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is RankineLong castInput => RankineLongConversions.RankineToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is RømerLong castInput => RømerLongConversions.RømerToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is DelisleLong castInput => DelisleLongConversions.DelisleToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is NewtonLong castInput => NewtonLongConversions.NewtonToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rankine) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToRankine(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is KelvinLong castInput => KelvinLongConversions.KelvinToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is GasLong castInput => GasLongConversions.GasToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is RankineLong castInput => RankineLongConversions.RankineToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is RømerLong castInput => RømerLongConversions.RømerToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is DelisleLong castInput => DelisleLongConversions.DelisleToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is NewtonLong castInput => NewtonLongConversions.NewtonToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Rømer) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToRømer(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is KelvinLong castInput => KelvinLongConversions.KelvinToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is GasLong castInput => GasLongConversions.GasToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is RankineLong castInput => RankineLongConversions.RankineToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is RømerLong castInput => RømerLongConversions.RømerToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is DelisleLong castInput => DelisleLongConversions.DelisleToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is NewtonLong castInput => NewtonLongConversions.NewtonToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Delisle) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToDelisle(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is KelvinLong castInput => KelvinLongConversions.KelvinToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is GasLong castInput => GasLongConversions.GasToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is RankineLong castInput => RankineLongConversions.RankineToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is RømerLong castInput => RømerLongConversions.RømerToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is DelisleLong castInput => DelisleLongConversions.DelisleToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is NewtonLong castInput => NewtonLongConversions.NewtonToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Newton) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToNewton(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is CelsiusLong castInput => CelsiusLongConversions.CelsiusToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is FahrenheitLong castInput => FahrenheitLongConversions.FahrenheitToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is KelvinLong castInput => KelvinLongConversions.KelvinToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is GasLong castInput => GasLongConversions.GasToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is RankineLong castInput => RankineLongConversions.RankineToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is RømerLong castInput => RømerLongConversions.RømerToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is DelisleLong castInput => DelisleLongConversions.DelisleToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is NewtonLong castInput => NewtonLongConversions.NewtonToRéaumur(castInput.Temperature),
            nameof(TemperatureTypes.Réaumur) when input is RéaumurLong castInput => RéaumurLongConversions.RéaumurToRéaumur(castInput.Temperature),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
