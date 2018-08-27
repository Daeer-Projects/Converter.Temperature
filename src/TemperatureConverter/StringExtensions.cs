using System;
using System.Globalization;

namespace TemperatureConverter
{
    /// <summary>
    /// A collection of string extensions that convert temperatures.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string CelsiusToCelsius(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.CelsiusToCelsius().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string CelsiusToFahrenheit(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.CelsiusToFahrenheit().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string CelsiusToKelvin(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.CelsiusToKelvin().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// Or the error message if the input is out of range for the gas mark.
        /// </returns>
        public static string CelsiusToGas(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                try
                {
                    convertedTemp = inputAsDouble.CelsiusToGas().ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string FahrenheitToCelsius(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.FahrenheitToCelsius().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string FahrenheitToFahrenheit(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.FahrenheitToFahrenheit().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string FahrenheitToKelvin(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.FahrenheitToKelvin().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// Or the error message if the input is out of range for the gas mark.
        /// </returns>
        public static string FahrenheitToGas(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                try
                {
                    convertedTemp = inputAsDouble.FahrenheitToGas().ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string KelvinToCelsius(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.KelvinToCelsius().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string KelvinToFahrenheit(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.KelvinToFahrenheit().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// </returns>
        public static string KelvinToKelvin(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                convertedTemp = inputAsDouble.KelvinToKelvin().ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// Or the error message if the input is out of range for the gas mark.
        /// </returns>
        public static string KelvinToGas(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                try
                {
                    convertedTemp = inputAsDouble.KelvinToGas().ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to celsius.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// Or the error message if the input is out of range for the gas mark.
        /// </returns>
        public static string GasToCelsius(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                try
                {
                    convertedTemp = inputAsDouble.GasToCelsius().ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to fahrenheit.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// Or the error message if the input is out of range for the gas mark.
        /// </returns>
        public static string GasToFahrenheit(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                try
                {
                    convertedTemp = inputAsDouble.GasToFahrenheit().ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to kelvin.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// Or the error message if the input is out of range for the gas mark.
        /// </returns>
        public static string GasToKelvin(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                try
                {
                    convertedTemp = inputAsDouble.GasToKelvin().ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        /// <summary>
        /// <c>String</c> extension that converts the selected <see langword="string"/> to gas.
        /// </summary>
        /// <param name="inputTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature as a <see langword="string"/>.
        /// Or the error message if the input is out of range for the gas mark.
        /// </returns>
        public static string GasToGas(this string inputTemp)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(inputTemp, out inputAsDouble))
            {
                try
                {
                    convertedTemp = inputAsDouble.GasToGas().ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }
    }
}
