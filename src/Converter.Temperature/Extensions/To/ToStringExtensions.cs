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
using Converter.Temperature.Extensions.To.Helpers;
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
///     The to string extensions.
/// </summary>
public static class ToStringExtensions
{
    /// <summary>
    ///     Converts the String input to the correct string value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static string To<TInput>(
        this StringBase input,
        int fractionalCount = -1)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(TemperatureTypes.Celsius) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToCelsius,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToFahrenheit,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToKelvin,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToGas,
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToGas,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToRankine,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToRømer,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToDelisle,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToNewton,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is CelsiusString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                CelsiusDoubleConversions.CelsiusToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is FahrenheitString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                FahrenheitDoubleConversions.FahrenheitToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is KelvinString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                KelvinDoubleConversions.KelvinToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is GasString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                GasDoubleConversion.GasToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RankineString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RankineDoubleConversions.RankineToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RømerString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RømerDoubleConversions.RømerToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is DelisleString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                DelisleDoubleConversions.DelisleToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is NewtonString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                NewtonDoubleConversions.NewtonToRéaumur,
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RéaumurString castInput => ToExtensionHelpers.Parser(
                castInput.Temperature,
                RéaumurDoubleConversions.RéaumurToRéaumur,
                fractionalCount),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
