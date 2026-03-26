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
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Double input to the correct double value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static double To<TInput>(
        this DoubleBase input,
        int fractionalCount = -1)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(TemperatureTypes.Celsius) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is CelsiusDouble castInput => ToExtensionHelpers.Rounder(
                CelsiusDoubleConversions.CelsiusToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is FahrenheitDouble castInput => ToExtensionHelpers.Rounder(
                FahrenheitDoubleConversions.FahrenheitToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is KelvinDouble castInput => ToExtensionHelpers.Rounder(
                KelvinDoubleConversions.KelvinToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is GasDouble castInput => ToExtensionHelpers.Rounder(
                GasDoubleConversion.GasToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RankineDouble castInput => ToExtensionHelpers.Rounder(
                RankineDoubleConversions.RankineToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RømerDouble castInput => ToExtensionHelpers.Rounder(
                RømerDoubleConversions.RømerToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is DelisleDouble castInput => ToExtensionHelpers.Rounder(
                DelisleDoubleConversions.DelisleToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is NewtonDouble castInput => ToExtensionHelpers.Rounder(
                NewtonDoubleConversions.NewtonToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RéaumurDouble castInput => ToExtensionHelpers.Rounder(
                RéaumurDoubleConversions.RéaumurToRéaumur(castInput.Temperature),
                fractionalCount),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
