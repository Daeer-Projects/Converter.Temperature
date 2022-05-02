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

    public static class FromLongExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius Long class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusLong FromCelsius(this long input)
        {
            return new CelsiusLong(input);
        }

        /// <summary>
        /// Sets the conversion to be from CelsiusDoubleConversions.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The CelsiusDoubleConversions Long class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitLong FromFahrenheit(this long input)
        {
            return new FahrenheitLong(input);
        }

        /// <summary>
        /// Sets the conversion to be from GasConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The GasConverter Long class for the 'To' extensions to use.
        /// </returns>
        public static GasLong FromGas(this long input)
        {
            return new GasLong(input);
        }

        /// <summary>
        /// Sets the conversion to be from KelvinConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The KelvinConverter Long class for the 'To' extensions to use.
        /// </returns>
        public static KelvinLong FromKelvin(this long input)
        {
            return new KelvinLong(input);
        }

        /// <summary>
        /// Sets the conversion to be from RankineConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The RankineConverter Long class for the 'To' extensions to use.
        /// </returns>
        public static RankineLong FromRankine(this long input)
        {
            return new RankineLong(input);
        }

        /// <summary>
        /// Sets the conversion to be from the TInput type.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
        /// <param name="input"> The value that is to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The LongBase specific class for the 'To' extension to use.
        /// </returns>
        public static LongBase From<TInput>(this long input)
            where TInput : TemperatureBase
        {
            return typeof(TInput).Name switch
            {
                nameof(Celsius) => new CelsiusLong(input),
                nameof(Fahrenheit) => new FahrenheitLong(input),
                nameof(Kelvin) => new KelvinLong(input),
                nameof(Gas) => new GasLong(input),
                nameof(Rankine) => new RankineLong(input),
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}
