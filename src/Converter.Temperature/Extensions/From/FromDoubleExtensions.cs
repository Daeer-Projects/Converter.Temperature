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
    /// The from <see langword="double"/> extensions.
    /// </summary>
    public static class FromDoubleExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius Double class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusDouble FromCelsius(this double input)
        {
            return new CelsiusDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from Fahrenheit.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Fahrenheit Double class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitDouble FromFahrenheit(this double input)
        {
            return new FahrenheitDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from Gas.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Gas Double class for the 'To' extensions to use.
        /// </returns>
        public static GasDouble FromGas(this double input)
        {
            return new GasDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from Kelvin.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Kelvin Double class for the 'To' extensions to use.
        /// </returns>
        public static KelvinDouble FromKelvin(this double input)
        {
            return new KelvinDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from Rankine.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Rankine Double class for the 'To' extension to use.
        /// </returns>
        public static RankineDouble FromRankine(this double input)
        {
            return new RankineDouble(input);
        }

        /// <summary>
        /// Sets the conversion to be from the TInput type.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
        /// <param name="input"> The value that is to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The DoubleBase specific class for the 'To' extension to use.
        /// </returns>
        public static DoubleBase From<TInput>(this double input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) => new CelsiusDouble(input),
                nameof(Fahrenheit) => new FahrenheitDouble(input),
                nameof(Kelvin) => new KelvinDouble(input),
                nameof(Gas) => new GasDouble(input),
                nameof(Rankine) => new RankineDouble(input),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}