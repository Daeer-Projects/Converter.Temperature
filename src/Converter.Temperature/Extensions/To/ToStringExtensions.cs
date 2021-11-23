namespace Converter.Temperature.Extensions.To
{
    using System.Globalization;
    using Converter.Temperature.Types.Celsius;
    using Converter.Temperature.Types.Fahrenheit;
    using Converter.Temperature.Types.Gas;
    using Converter.Temperature.Types.Kelvin;

    /// <summary>
    /// The to string extensions.
    /// </summary>
    public static class ToStringExtensions
    {
        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Celsius.CelsiusToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Fahrenheit.FahrenheitToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Gas.GasToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Celsius
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Celsius string result.
        /// </returns>
        public static string ToCelsius(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Kelvin.KelvinToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit string result.
        /// </returns>
        public static string ToFahrenheit(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Celsius.CelsiusToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Fahrenheit string result.
        /// </returns>
        public static string ToFahrenheit(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Fahrenheit.FahrenheitToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Fahrenheit string result.
        /// </returns>
        public static string ToFahrenheit(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Gas.GasToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Fahrenheit
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Fahrenheit string result.
        /// </returns>
        public static string ToFahrenheit(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Kelvin.KelvinToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas string result.
        /// </returns>
        public static string ToGas(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Celsius.CelsiusToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas string result.
        /// </returns>
        public static string ToGas(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Fahrenheit.FahrenheitToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas string result.
        /// </returns>
        public static string ToGas(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Gas.GasToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Gas
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Gas string result.
        /// </returns>
        public static string ToGas(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Kelvin.KelvinToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Celsius <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin string result.
        /// </returns>
        public static string ToKelvin(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Celsius.CelsiusToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Fahrenheit <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If calculated value is beyond the limits of the type.</exception>
        /// <returns>
        /// The Kelvin string result.
        /// </returns>
        public static string ToKelvin(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Fahrenheit.FahrenheitToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Gas <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Temp too low or too high for gas mark!</exception>
        /// <returns>
        /// The Kelvin string result.
        /// </returns>
        public static string ToKelvin(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Gas.GasToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        /// <summary>
        /// Converts the Kelvin <paramref name="input"/> to Kelvin
        /// </summary>
        /// <param name="input"> The value to be converted. </param>
        /// <returns>
        /// The Kelvin string result.
        /// </returns>
        public static string ToKelvin(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Kelvin.KelvinToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }
    }
}
