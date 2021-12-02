namespace Converter.Temperature.Extensions.From
{
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
        /// Sets the conversion to be from Fahrenheit.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Fahrenheit Int class for the 'To' extensions to use.
        /// </returns>
        public static FahrenheitInt FromFahrenheit(this int input)
        {
            return new FahrenheitInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from Gas.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Gas Int class for the 'To' extensions to use.
        /// </returns>
        public static GasInt FromGas(this int input)
        {
            return new GasInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from Kelvin.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Kelvin Int class for the 'To' extensions to use.
        /// </returns>
        public static KelvinInt FromKelvin(this int input)
        {
            return new KelvinInt(input);
        }

        /// <summary>
        /// Sets the conversion to be from Rankine.
        /// </summary>
        /// <param name="input"> The value that is to be converted. </param>
        /// <returns>
        /// The Rankine Int class for the 'To' extensions to use.
        /// </returns>
        public static RankineInt FromRankine(this int input)
        {
            return new RankineInt(input);
        }
    }
}