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
///     The to <see langword="float" /> extensions.
/// </summary>
public static class ToFloatExtensions
{
    /// <summary>
    ///     Converts the float input to the correct float value.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted to. </typeparam>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static float To<TInput>(
        this FloatBase input,
        int fractionalCount = -1)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(TemperatureTypes.Celsius) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Celsius) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Fahrenheit) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Kelvin) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Gas) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToGas(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rankine) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToRankine(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Rømer) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToRømer(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Delisle) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToDelisle(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Newton) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToNewton(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is CelsiusFloat castInput => ToExtensionHelpers.Rounder(
                CelsiusFloatConversions.CelsiusToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is FahrenheitFloat castInput => ToExtensionHelpers.Rounder(
                FahrenheitFloatConversions.FahrenheitToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is KelvinFloat castInput => ToExtensionHelpers.Rounder(
                KelvinFloatConversions.KelvinToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is GasFloat castInput => ToExtensionHelpers.Rounder(
                GasFloatConversions.GasToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RankineFloat castInput => ToExtensionHelpers.Rounder(
                RankineFloatConversions.RankineToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RømerFloat castInput => ToExtensionHelpers.Rounder(
                RømerFloatConversions.RømerToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is DelisleFloat castInput => ToExtensionHelpers.Rounder(
                DelisleFloatConversions.DelisleToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is NewtonFloat castInput => ToExtensionHelpers.Rounder(
                NewtonFloatConversions.NewtonToRéaumur(castInput.Temperature),
                fractionalCount),
            nameof(TemperatureTypes.Réaumur) when input is RéaumurFloat castInput => ToExtensionHelpers.Rounder(
                RéaumurFloatConversions.RéaumurToRéaumur(castInput.Temperature),
                fractionalCount),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
