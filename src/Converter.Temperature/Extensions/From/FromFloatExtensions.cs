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
    /// The from <see langword="float"/> extensions.
    /// </summary>
    public static class FromFloatExtensions
    {
        /// <summary>
        /// Sets the conversion to be from Celsius.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Celsius Float class for the 'To' extensions to use.
        /// </returns>
        public static CelsiusFloat FromCelsius(this float input)
        {
            return new CelsiusFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from FahrenheitConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The FahrenheitConverter Float class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitFloat FromFahrenheit(this float input)
        {
            return new FahrenheitFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from GasConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The GasConverter Float class for the 'To' extensions to use.
        /// </returns>
        public static GasFloat FromGas(this float input)
        {
            return new GasFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from KelvinConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The KelvinConverter Float class for the 'To' extensions to use.
        /// </returns>
        public static KelvinFloat FromKelvin(this float input)
        {
            return new KelvinFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from RankineConverter.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The RankineConverter Float class for the 'To' extensions to use.
        /// </returns>
        public static RankineFloat FromRankine(this float input)
        {
            return new RankineFloat(input);
        }

        /// <summary>
        /// Sets the conversion to be from the TInput type.
        /// </summary>
        /// <typeparam name="TInput"> The temperature type to be converted from. </typeparam>
        /// <param name="input"> The value that is to be converted. </param>
        /// <exception cref="ArgumentException"> The TInput type is not a valid type for this method. </exception>
        /// <returns>
        /// The FloatBase specific class for the 'To' extension to use.
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
                _ => throw new ArgumentException($"Invalid type: {typeof(TInput).Name}")
            };
        }
    }
}