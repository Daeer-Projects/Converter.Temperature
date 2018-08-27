using System;
using System.Globalization;

namespace TemperatureConverter
{
    /// <summary>
    /// A collection of float extensions that convert temperatures.
    /// </summary>
    public static class FloatExtensions
    {
        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="int"/>.
        /// </returns>
        public static float CelsiusToCelsius(this float inputTemp)
        {
            var convertedTemp = inputTemp;
            float.TryParse(
                TemperatureConverter.CelsiusToCelsius(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float CelsiusToFahrenheit(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.CelsiusToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float CelsiusToKelvin(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.CelsiusToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float CelsiusToGas(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.CelsiusToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float FahrenheitToCelsius(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.FahrenheitToCelsius(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float FahrenheitToFahrenheit(this float inputTemp)
        {
            var convertedTemp = inputTemp;
            float.TryParse(
                TemperatureConverter.FahrenheitToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float FahrenheitToKelvin(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.FahrenheitToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float FahrenheitToGas(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.FahrenheitToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float KelvinToCelsius(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.KelvinToCelsius(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float KelvinToFahrenheit(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.KelvinToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float KelvinToKelvin(this float inputTemp)
        {
            var convertedTemp = inputTemp;
            float.TryParse(
                TemperatureConverter.KelvinToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float KelvinToGas(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.KelvinToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float GasToCelsius(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.GasToCelsius(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float GasToFahrenheit(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.GasToFahrenheit(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float GasToKelvin(this float inputTemp)
        {
            var convertedTemp = 0f;
            float.TryParse(
                TemperatureConverter.GasToKelvin(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        /// <summary>
        /// Float extension that converts the selected <see langword="float"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="float"/>.
        /// </returns>
        public static float GasToGas(this float inputTemp)
        {
            var convertedTemp = inputTemp;
            float.TryParse(
                TemperatureConverter.GasToGas(inputTemp).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }
    }
}