using System;
using Converter.Temperature.BaseTypes;
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

namespace Converter.Temperature.Extensions.From;

/// <summary>
///     The from <see langword="int" /> extensions.
/// </summary>
public static class FromIntExtensions
{
    /// <summary>
    ///     Sets the conversion to be from Celsius.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Celsius Int class for the 'To' extensions to use.
    /// </returns>
    public static CelsiusInt FromCelsius(
        this int input)
    {
        return new CelsiusInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Fahrenheit.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Fahrenheit Int class for the 'To' extensions to use.
    /// </returns>
    public static FahrenheitInt FromFahrenheit(
        this int input)
    {
        return new FahrenheitInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Gas.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Gas Int class for the 'To' extensions to use.
    /// </returns>
    public static GasInt FromGas(
        this int input)
    {
        return new GasInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Kelvin.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Kelvin Int class for the 'To' extensions to use.
    /// </returns>
    public static KelvinInt FromKelvin(
        this int input)
    {
        return new KelvinInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Rankine.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Rankine Int class for the 'To' extensions to use.
    /// </returns>
    public static RankineInt FromRankine(
        this int input)
    {
        return new RankineInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Rømer.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Rømer Int class for the 'To' extension to use.
    /// </returns>
    public static RømerInt FromRømer(
        this int input)
    {
        return new RømerInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Delisle.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Delisle Int class for the 'To' extension to use.
    /// </returns>
    public static DelisleInt FromDelisle(
        this int input)
    {
        return new DelisleInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Newton.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Newton Int class for the 'To' extension to use.
    /// </returns>
    public static NewtonInt FromNewton(
        this int input)
    {
        return new NewtonInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Réaumur.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Réaumur Int class for the 'To' extension to use.
    /// </returns>
    public static RéaumurInt FromRéaumur(
        this int input)
    {
        return new RéaumurInt(input);
    }

    /// <summary>
    ///     Sets the conversion to be from the TInput type.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
    /// <param name="input"> The value that is to be converted. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <returns>
    ///     The IntBase specific class for the 'To' extension to use.
    /// </returns>
    public static IntBase From<TInput>(
        this int input)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) => new CelsiusInt(input),
            nameof(Fahrenheit) => new FahrenheitInt(input),
            nameof(Kelvin) => new KelvinInt(input),
            nameof(Gas) => new GasInt(input),
            nameof(Rankine) => new RankineInt(input),
            nameof(Rømer) => new RømerInt(input),
            nameof(Delisle) => new DelisleInt(input),
            nameof(Newton) => new NewtonInt(input),
            nameof(Réaumur) => new RéaumurInt(input),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
