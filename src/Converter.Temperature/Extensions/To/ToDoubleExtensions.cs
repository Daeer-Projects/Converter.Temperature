using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.To
{
    /// <summary>
    /// The to <see langword="double"/> extensions.
    /// </summary>
    public static class ToDoubleExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this CelsiusDouble input)
        {
            return Temperature.CelsiusToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this FahrenheitDouble input)
        {
            return Temperature.FahrenheitToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this GasDouble input)
        {
            return Temperature.GasToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius <see langword="double"/> result.
        /// </returns>
        public static double ToCelsius(this KelvinDouble input)
        {
            return Temperature.KelvinToCelsius(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this CelsiusDouble input)
        {
            return Temperature.CelsiusToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this FahrenheitDouble input)
        {
            return Temperature.FahrenheitToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this GasDouble input)
        {
            return Temperature.GasToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit <see langword="double"/> result.
        /// </returns>
        public static double ToFahrenheit(this KelvinDouble input)
        {
            return Temperature.KelvinToFahrenheit(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this CelsiusDouble input)
        {
            return Temperature.CelsiusToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this FahrenheitDouble input)
        {
            return Temperature.FahrenheitToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this GasDouble input)
        {
            return Temperature.GasToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas <see langword="double"/> result.
        /// </returns>
        public static double ToGas(this KelvinDouble input)
        {
            return Temperature.KelvinToGas(input.Temperature);
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this CelsiusDouble input)
        {
            return Temperature.CelsiusToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this FahrenheitDouble input)
        {
            return Temperature.FahrenheitToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this GasDouble input)
        {
            return Temperature.GasToKelvin(input.Temperature);
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin <see langword="double"/> result.
        /// </returns>
        public static double ToKelvin(this KelvinDouble input)
        {
            return Temperature.KelvinToKelvin(input.Temperature);
        }
    }
}