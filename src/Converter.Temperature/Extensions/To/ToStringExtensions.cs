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
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToCelsius(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.FahrenheitToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToCelsius(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.GasToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToCelsius(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.KelvinToCelsius(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.FahrenheitToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.GasToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToFahrenheit(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.KelvinToFahrenheit(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToGas(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToGas(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.FahrenheitToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToGas(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.GasToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToGas(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.KelvinToGas(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToKelvin(this CelsiusString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.CelsiusToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToKelvin(this FahrenheitString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.FahrenheitToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToKelvin(this GasString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.GasToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }

        public static string ToKelvin(this KelvinString input)
        {
            var convertedTemp = string.Empty;
            if (double.TryParse(input.Temperature, out var inputAsDouble))
            {
                convertedTemp = Temperature.KelvinToKelvin(inputAsDouble).ToString(CultureInfo.InvariantCulture);
            }

            return convertedTemp;
        }
    }
}
