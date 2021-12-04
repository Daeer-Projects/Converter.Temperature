namespace Converter.Temperature.Extensions.From
{
    using System;
    using BaseTypes;
    using TemperatureTypes;
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;

    /// <summary>
    /// The from string extensions.
    /// </summary>
    public static class FromStringExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius String class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusString FromCelsius(this string input)
        {
            return new CelsiusString(input);
        }

        /// <summary>
        /// Sets the conversion to be from FahrenheitConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter String class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitString FromFahrenheit(this string input)
        {
            return new FahrenheitString(input);
        }

        /// <summary>
        /// Sets the conversion to be from GasConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The GasConverter String class for the 'To' extensions to use.
        /// </returns>
        public static GasString FromGas(this string input)
        {
            return new GasString(input);
        }

        /// <summary>
        /// Sets the conversion to be from KelvinConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The KelvinConverter String class for the 'To' extensions to use.
        /// </returns>
        public static KelvinString FromKelvin(this string input)
        {
            return new KelvinString(input);
        }

        /// <summary>
        /// Sets the conversion to be from RankineConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The RankineConverter String class for the 'To' extensions to use.
        /// </returns>
        public static RankineString FromRankine(this string input)
        {
            return new RankineString(input);
        }

        /// <summary>
        /// Sets the conversion to be from the TInput type.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
        /// <param name="input"> The value that is to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The StringBase specific class for the 'To' extension to use.
        /// </returns>
        public static StringBase From<TInput>(this string input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) => new CelsiusString(input),
                nameof(Fahrenheit) => new FahrenheitString(input),
                nameof(Kelvin) => new KelvinString(input),
                nameof(Gas) => new GasString(input),
                nameof(Rankine) => new RankineString(input),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}