using System.Globalization;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.To
{
    public static class ToIntExtensions
    {
        public static int ToCelsius(this CelsiusInt input)
        {
            var convertedTemp = input.Temperature;
            int.TryParse(
                Temperature.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToCelsius(this FahrenheitInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.CelsiusToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToCelsius(this GasInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToCelsius(this KelvinInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.KelvinToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this CelsiusInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.CelsiusToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this FahrenheitInt input)
        {
            var convertedTemp = input.Temperature;
            int.TryParse(
                Temperature.FahrenheitToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this GasInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.GasToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this KelvinInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.KelvinToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this CelsiusInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.CelsiusToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this FahrenheitInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.FahrenheitToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this GasInt input)
        {
            var convertedTemp = input.Temperature;
            int.TryParse(
                Temperature.GasToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this KelvinInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.KelvinToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this CelsiusInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.CelsiusToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this FahrenheitInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.FahrenheitToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this GasInt input)
        {
            var convertedTemp = 0;
            int.TryParse(
                Temperature.GasToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this KelvinInt input)
        {
            var convertedTemp = input.Temperature;
            int.TryParse(
                Temperature.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }
    }
}