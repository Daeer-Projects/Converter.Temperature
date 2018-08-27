using System;

namespace TemperatureConverter
{
    /// <summary>
    /// A collection of double extensions that convert temperatures.
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double CelsiusToCelsius(this double inputTemp)
        {
            return TemperatureConverter.CelsiusToCelsius(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double CelsiusToFahrenheit(this double inputTemp)
        {
            return TemperatureConverter.CelsiusToFahrenheit(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double CelsiusToKelvin(this double inputTemp)
        {
            return TemperatureConverter.CelsiusToKelvin(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double CelsiusToGas(this double inputTemp)
        {
            return TemperatureConverter.CelsiusToGas(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double FahrenheitToCelsius(this double inputTemp)
        {
            return TemperatureConverter.FahrenheitToCelsius(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double FahrenheitToFahrenheit(this double inputTemp)
        {
            return TemperatureConverter.FahrenheitToFahrenheit(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double FahrenheitToKelvin(this double inputTemp)
        {
            return TemperatureConverter.FahrenheitToKelvin(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double FahrenheitToGas(this double inputTemp)
        {
            return TemperatureConverter.FahrenheitToGas(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double KelvinToCelsius(this double inputTemp)
        {
            return TemperatureConverter.KelvinToCelsius(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double KelvinToFahrenheit(this double inputTemp)
        {
            return TemperatureConverter.KelvinToFahrenheit(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double KelvinToKelvin(this double inputTemp)
        {
            return TemperatureConverter.KelvinToKelvin(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double KelvinToGas(this double inputTemp)
        {
            return TemperatureConverter.KelvinToGas(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double GasToCelsius(this double inputTemp)
        {
            return TemperatureConverter.GasToCelsius(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double GasToFahrenheit(this double inputTemp)
        {
            return TemperatureConverter.GasToFahrenheit(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double GasToKelvin(this double inputTemp)
        {
            return TemperatureConverter.GasToKelvin(inputTemp);
        }

        /// <summary>
        /// Double extension that converts the selected <see langword="double"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature as a <see langword="double"/>.
        /// </returns>
        public static double GasToGas(this double inputTemp)
        {
            return TemperatureConverter.GasToGas(inputTemp);
        }
    }
}