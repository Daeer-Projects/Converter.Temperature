namespace Converter.Temperature.Extensions.From;

using System;
using BaseTypes;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;

/// <summary>
///     The from <see langword="float" /> extensions.
/// </summary>
public static class FromFloatExtensions
{
    /// <summary>
    ///     Sets the conversion to be from Celsius.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Celsius Float class for the 'To' extensions to use.
    /// </returns>
    public static CelsiusFloat FromCelsius(this float input)
    {
        return new CelsiusFloat(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Fahrenheit.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Fahrenheit Float class for the 'To' extensions to use.
    /// </returns>
    public static FahrenheitFloat FromFahrenheit(this float input)
    {
        return new FahrenheitFloat(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Gas.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Gas Float class for the 'To' extensions to use.
    /// </returns>
    public static GasFloat FromGas(this float input)
    {
        return new GasFloat(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Kelvin.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Kelvin Float class for the 'To' extensions to use.
    /// </returns>
    public static KelvinFloat FromKelvin(this float input)
    {
        return new KelvinFloat(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Rankine.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Rankine Float class for the 'To' extensions to use.
    /// </returns>
    public static RankineFloat FromRankine(this float input)
    {
        return new RankineFloat(input);
    }

    /// <summary>
    ///     Sets the conversion to be from Rømer.
    /// </summary>
    /// <param name="input"> The value that is to be converted. </param>
    /// <returns>
    ///     The Rømer Float class for the 'To' extension to use.
    /// </returns>
    public static RømerFloat FromRømer(this float input)
    {
        return new RømerFloat(input);
    }

    /// <summary>
    ///     Sets the conversion to be from the TInput type.
    /// </summary>
    /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
    /// <param name="input"> The value that is to be converted. </param>
    /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
    /// <returns>
    ///     The FloatBase specific class for the 'To' extension to use.
    /// </returns>
    public static FloatBase From<TInput>(this float input)
        where TInput : TemperatureBase
    {
        return typeof(TInput).Name switch
        {
            nameof(Celsius) => new CelsiusFloat(input),
            nameof(Fahrenheit) => new FahrenheitFloat(input),
            nameof(Kelvin) => new KelvinFloat(input),
            nameof(Gas) => new GasFloat(input),
            nameof(Rankine) => new RankineFloat(input),
            nameof(Rømer) => new RømerFloat(input),
            _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
        };
    }
}