namespace Converter.Temperature.Extensions.From
{
using Converter.Temperature.BaseTypes;
using Converter.Temperature.TemperatureTypes;
using System;
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;

    /// <summary>
    /// The from <see langword="int"/> extensions.
    /// </summary>
    public static class FromIntExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius Int class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusInt FromCelsius(this int input)
        {
            return new CelsiusInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from FahrenheitConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter Int class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitInt FromFahrenheit(this int input)
        {
            return new FahrenheitInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from GasConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The GasConverter Int class for the 'To' extensions to use.
        /// </returns>
        public static GasInt FromGas(this int input)
        {
            return new GasInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from KelvinConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The KelvinConverter Int class for the 'To' extensions to use.
        /// </returns>
        public static KelvinInt FromKelvin(this int input)
        {
            return new KelvinInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from RankineConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The RankineConverter Int class for the 'To' extensions to use.
        /// </returns>
        public static RankineInt FromRankine(this int input)
        {
            return new RankineInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from the TInput type.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
        /// <param name="input"> The value that is to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The IntBase specific class for the 'To' extension to use.
        /// </returns>
        public static IntBase From<TInput>(this int input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) => new CelsiusInt(input),
                nameof(Fahrenheit) => new FahrenheitInt(input),
                nameof(Kelvin) => new KelvinInt(input),
                nameof(Gas) => new GasInt(input),
                nameof(Rankine) => new RankineInt(input),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}