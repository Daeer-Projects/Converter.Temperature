using System;
using System.Globalization;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.To
{
    public static class ToStringExtensions
    {
        public static string ToCelsius(this CelsiusString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToCelsius(this FahrenheitString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.FahrenheitToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToCelsius(this GasString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.GasToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToCelsius(this KelvinString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.KelvinToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this CelsiusString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this FahrenheitString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.FahrenheitToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this GasString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.GasToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this KelvinString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.KelvinToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToGas(this CelsiusString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToGas(this FahrenheitString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                try
                {
                    convertedTemp = Temperature.FahrenheitToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        public static string ToGas(this GasString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                try
                {
                    convertedTemp = Temperature.GasToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        public static string ToGas(this KelvinString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                try
                {
                    convertedTemp = Temperature.KelvinToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    convertedTemp = rangeException.Message;
                }
            }

            return convertedTemp;
        }

        public static string ToKelvin(this CelsiusString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToKelvin(this FahrenheitString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.FahrenheitToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToKelvin(this GasString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.GasToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToKelvin(this KelvinString input)
        {
            double inputAsDouble;
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out inputAsDouble))
            {
                convertedTemp = Temperature.KelvinToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }
    }
}
