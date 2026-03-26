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
///     The from <see langword="double" /> extensions.
/// </summary>
public static class FromDoubleExtensions
{
    /// <summary>
    ///     Sets the conversion to be from Celsius.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Celsius Double class for the 'To' extensions to use.
    /// </returns>
    public static CelsiusDouble FromCelsius(
        this double input)
    {
        return new CelsiusDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Fahrenheit.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Fahrenheit Double class for the 'To' extensions to use.
    /// </returns>
    public static FahrenheitDouble FromFahrenheit(
        this double input)
    {
        return new FahrenheitDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Gas.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Gas Double class for the 'To' extensions to use.
    /// </returns>
    public static GasDouble FromGas(
        this double input)
    {
        return new GasDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Kelvin.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Kelvin Double class for the 'To' extensions to use.
    /// </returns>
    public static KelvinDouble FromKelvin(
        this double input)
    {
        return new KelvinDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Rankine.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Rankine Double class for the 'To' extension to use.
    /// </returns>
    public static RankineDouble FromRankine(
        this double input)
    {
        return new RankineDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Rømer.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Rømer Double class for the 'To' extension to use.
    /// </returns>
    public static RømerDouble FromRømer(
        this double input)
    {
        return new RømerDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Delisle.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Delisle Double class for the 'To' extension to use.
    /// </returns>
    public static DelisleDouble FromDelisle(
        this double input)
    {
        return new DelisleDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Newton.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Newton Double class for the 'To' extension to use.
    /// </returns>
    public static NewtonDouble FromNewton(
        this double input)
    {
        return new NewtonDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Réaumur.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Réaumur Double class for the 'To' extension to use.
    /// </returns>
    public static RéaumurDouble FromRéaumur(
        this double input)
    {
        return new RéaumurDouble(input);
    }

    /// <summary>
    ///     Sets the conversion to be from the TInput type.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
    /// <param name="input"> The value that is to be converted. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <returns>
    ///     The DoubleBase specific class for the 'To' extension to use.
    /// </returns>
    public static DoubleBase From<TInput>(
        this double input)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) => new CelsiusDouble(input),
            nameof(Fahrenheit) => new FahrenheitDouble(input),
            nameof(Kelvin) => new KelvinDouble(input),
            nameof(Gas) => new GasDouble(input),
            nameof(Rankine) => new RankineDouble(input),
            nameof(Rømer) => new RømerDouble(input),
            nameof(Delisle) => new DelisleDouble(input),
            nameof(Newton) => new NewtonDouble(input),
            nameof(Réaumur) => new RéaumurDouble(input),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}
