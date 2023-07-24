namespace Converter.Temperature.Extensions.To;

using System;
using BaseTypes;
using Converters.Celsius;
using Converters.Fahrenheit;
using Converters.Gas;
using Converters.Kelvin;
using Converters.Rankine;
using Converters.Rømer;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The to <see langword="double" /> extensions.
/// </summary>
public static class ToDoubleExtensions
{
    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Celsius <see langword="double" /> result.
    /// </returns>
    public static double ToCelsius(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return Rounder(CelsiusDoubleConversions.CelsiusToCelsius(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Celsius <see langword="double" /> result.
    /// </returns>
    public static double ToCelsius(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return Rounder(FahrenheitDoubleConversions.FahrenheitToCelsius(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Celsius <see langword="double" /> result.
    /// </returns>
    public static double ToCelsius(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return Rounder(GasDoubleConversion.GasToCelsius(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Celsius <see langword="double" /> result.
    /// </returns>
    public static double ToCelsius(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return Rounder(KelvinDoubleConversions.KelvinToCelsius(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Celsius <see langword="double" /> result.
    /// </returns>
    public static double ToCelsius(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RankineDoubleConversions.RankineToCelsius(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Celsius
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Celsius <see langword="double" /> result.
    /// </returns>
    public static double ToCelsius(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RømerDoubleConversions.RømerToCelsius(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="double" /> result.
    /// </returns>
    public static double ToFahrenheit(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return Rounder(CelsiusDoubleConversions.CelsiusToFahrenheit(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="double" /> result.
    /// </returns>
    public static double ToFahrenheit(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return Rounder(FahrenheitDoubleConversions.FahrenheitToFahrenheit(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="double" /> result.
    /// </returns>
    public static double ToFahrenheit(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return Rounder(GasDoubleConversion.GasToFahrenheit(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="double" /> result.
    /// </returns>
    public static double ToFahrenheit(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return Rounder(KelvinDoubleConversions.KelvinToFahrenheit(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="double" /> result.
    /// </returns>
    public static double ToFahrenheit(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RankineDoubleConversions.RankineToFahrenheit(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Fahrenheit
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Fahrenheit <see langword="double" /> result.
    /// </returns>
    public static double ToFahrenheit(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RømerDoubleConversions.RømerToFahrenheit(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Gas <see langword="double" /> result.
    /// </returns>
    public static double ToGas(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return Rounder(CelsiusDoubleConversions.CelsiusToGas(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Gas <see langword="double" /> result.
    /// </returns>
    public static double ToGas(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return Rounder(FahrenheitDoubleConversions.FahrenheitToGas(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Gas <see langword="double" /> result.
    /// </returns>
    public static double ToGas(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return Rounder(GasDoubleConversion.GasToGas(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The GasConverter <see langword="double" /> result.
    /// </returns>
    public static double ToGas(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return Rounder(KelvinDoubleConversions.KelvinToGas(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The GasConverter <see langword="double" /> result.
    /// </returns>
    public static double ToGas(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RankineDoubleConversions.RankineToGas(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Gas
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Gas <see langword="double" /> result.
    /// </returns>
    public static double ToGas(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RømerDoubleConversions.RømerToGas(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return Rounder(CelsiusDoubleConversions.CelsiusToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return Rounder(FahrenheitDoubleConversions.FahrenheitToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Gas <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return Rounder(GasDoubleConversion.GasToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return Rounder(KelvinDoubleConversions.KelvinToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RankineDoubleConversions.RankineToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Kelvin
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Kelvin <see langword="double" /> result.
    /// </returns>
    public static double ToKelvin(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RømerDoubleConversions.RømerToKelvin(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Celsius <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this CelsiusDouble input,
        int fractionalCount = -1)
    {
        return Rounder(CelsiusDoubleConversions.CelsiusToRankine(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this FahrenheitDouble input,
        int fractionalCount = -1)
    {
        return Rounder(FahrenheitDoubleConversions.FahrenheitToRankine(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Fahrenheit <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this GasDouble input,
        int fractionalCount = -1)
    {
        return Rounder(GasDoubleConversion.GasToRankine(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Kelvin <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this KelvinDouble input,
        int fractionalCount = -1)
    {
        return Rounder(KelvinDoubleConversions.KelvinToRankine(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rankine <paramref name="input" /> to Ranking
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this RankineDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RankineDoubleConversions.RankineToRankine(input.Temperature), fractionalCount);
    }

    /// <summary>
    ///     Converts the Rømer <paramref name="input" /> to Rankine
    /// </summary>
    /// <param name="input"> The value to be converted. </param>
    /// <param name="fractionalCount"> The count of fractional after the decimal point. </param>
    /// <exception cref="ArgumentOutOfRangeException"> If fractional count is greater than 15. </exception>
    /// <returns>
    ///     The Rankine <see langword="double" /> result.
    /// </returns>
    public static double ToRankine(
        this RømerDouble input,
        int fractionalCount = -1)
    {
        return Rounder(RømerDoubleConversions.RømerToRankine(input.Temperature), fractionalCount);
    }

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
            nameof(Celsius) when input is CelsiusDouble castInput => Rounder(
                CelsiusDoubleConversions.CelsiusToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is FahrenheitDouble castInput => Rounder(
                FahrenheitDoubleConversions.FahrenheitToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is KelvinDouble castInput => Rounder(
                KelvinDoubleConversions.KelvinToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is GasDouble castInput => Rounder(
                GasDoubleConversion.GasToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is RankineDouble castInput => Rounder(
                RankineDoubleConversions.RankineToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Celsius) when input is RømerDouble castInput => Rounder(
                RømerDoubleConversions.RømerToCelsius(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is CelsiusDouble castInput => Rounder(
                CelsiusDoubleConversions.CelsiusToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is FahrenheitDouble castInput => Rounder(
                FahrenheitDoubleConversions.FahrenheitToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is KelvinDouble castInput => Rounder(
                KelvinDoubleConversions.KelvinToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is GasDouble castInput => Rounder(
                GasDoubleConversion.GasToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is RankineDouble castInput => Rounder(
                RankineDoubleConversions.RankineToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Fahrenheit) when input is RømerDouble castInput => Rounder(
                RømerDoubleConversions.RømerToFahrenheit(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is CelsiusDouble castInput => Rounder(
                CelsiusDoubleConversions.CelsiusToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is FahrenheitDouble castInput => Rounder(
                FahrenheitDoubleConversions.FahrenheitToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is KelvinDouble castInput => Rounder(
                KelvinDoubleConversions.KelvinToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is GasDouble castInput => Rounder(
                GasDoubleConversion.GasToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is RankineDouble castInput => Rounder(
                RankineDoubleConversions.RankineToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Kelvin) when input is RømerDouble castInput => Rounder(
                RømerDoubleConversions.RømerToKelvin(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is CelsiusDouble castInput => Rounder(
                CelsiusDoubleConversions.CelsiusToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is FahrenheitDouble castInput => Rounder(
                FahrenheitDoubleConversions.FahrenheitToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is KelvinDouble castInput => Rounder(
                KelvinDoubleConversions.KelvinToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is GasDouble castInput => Rounder(
                GasDoubleConversion.GasToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is RankineDouble castInput => Rounder(
                RankineDoubleConversions.RankineToGas(castInput.Temperature),
                fractionalCount),
            nameof(Gas) when input is RømerDouble castInput => Rounder(
                RømerDoubleConversions.RømerToGas(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is CelsiusDouble castInput => Rounder(
                CelsiusDoubleConversions.CelsiusToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is FahrenheitDouble castInput => Rounder(
                FahrenheitDoubleConversions.FahrenheitToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is KelvinDouble castInput => Rounder(
                KelvinDoubleConversions.KelvinToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is GasDouble castInput => Rounder(
                GasDoubleConversion.GasToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is RankineDouble castInput => Rounder(
                RankineDoubleConversions.RankineToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rankine) when input is RømerDouble castInput => Rounder(
                RømerDoubleConversions.RømerToRankine(castInput.Temperature),
                fractionalCount),
            nameof(Rømer) when input is CelsiusDouble castInput => Rounder(
                CelsiusDoubleConversions.CelsiusToRømer(castInput.Temperature),
                fractionalCount),
            //nameof(Rømer) when input is FahrenheitDouble castInput => Rounder(
            //    FahrenheitDoubleConversions.FahrenheitToRankine(castInput.Temperature),
            //    fractionalCount),
            //nameof(Rømer) when input is KelvinDouble castInput => Rounder(
            //    KelvinDoubleConversions.KelvinToRankine(castInput.Temperature),
            //    fractionalCount),
            //nameof(Rømer) when input is GasDouble castInput => Rounder(
            //    GasDoubleConversion.GasToRankine(castInput.Temperature),
            //    fractionalCount),
            //nameof(Rømer) when input is RankineDouble castInput => Rounder(
            //    RankineDoubleConversions.RankineToRankine(castInput.Temperature),
            //    fractionalCount),
            //nameof(Rømer) when input is RømerDouble castInput => Rounder(
            //    RømerDoubleConversions.RømerToRankine(castInput.Temperature),
            //    fractionalCount),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }

    private static double Rounder(
        double input,
        int fractionalCount = -1)
    {
        return fractionalCount < 0 ? input : Math.Round(input, fractionalCount);
    }
}
