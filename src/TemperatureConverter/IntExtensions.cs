using System;
using System.Globalization;

namespace TemperatureConverter
{
    /// <summary>
    /// A collection of integer extensions that convert temperatures.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="OverflowException">
        ///         <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />.
        /// </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int CelsiusToCelsius(this int inputTemp)
        {
            return Convert.ToInt32(TemperatureConverter.CelsiusToCelsius(inputTemp));
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int CelsiusToFahrenheit(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.CelsiusToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int CelsiusToKelvin(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.CelsiusToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int CelsiusToGas(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.CelsiusToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int FahrenheitToCelsius(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.FahrenheitToCelsius(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int FahrenheitToFahrenheit(this int inputTemp)
        {
            var convertedTemp = inputTemp;
            int.TryParse(
                TemperatureConverter.FahrenheitToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int FahrenheitToKelvin(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.FahrenheitToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int FahrenheitToGas(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.FahrenheitToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int KelvinToCelsius(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.KelvinToCelsius(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int KelvinToFahrenheit(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.KelvinToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int KelvinToKelvin(this int inputTemp)
        {
            var convertedTemp = inputTemp;
            int.TryParse(
                TemperatureConverter.KelvinToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int KelvinToGas(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.KelvinToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int GasToCelsius(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.GasToCelsius(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int GasToFahrenheit(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.GasToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int GasToKelvin(this int inputTemp)
        {
            var convertedTemp = 0;
            int.TryParse(
                TemperatureConverter.GasToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Integer extension that converts the selected <see langword="int"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as an <see langword="int"/>.
        /// </returns>
        public static int GasToGas(this int inputTemp)
        {
            var convertedTemp = inputTemp;
            int.TryParse(
                TemperatureConverter.GasToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }
    }
}