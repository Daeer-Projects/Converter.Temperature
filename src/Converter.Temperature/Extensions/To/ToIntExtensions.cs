using System;
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
            int.TryParse(
                Temperature.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToCelsius(this FahrenheitInt input)
        {
            int.TryParse(
                Temperature.FahrenheitToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToCelsius(this GasInt input)
        {
            int.TryParse(
                Temperature.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToCelsius(this KelvinInt input)
        {
            int.TryParse(
                Math.Round(Temperature.KelvinToCelsius(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this CelsiusInt input)
        {
            int.TryParse(
                Math.Round(Temperature.CelsiusToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this FahrenheitInt input)
        {
            int.TryParse(
                Temperature.FahrenheitToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this GasInt input)
        {
            int.TryParse(
                Temperature.GasToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToFahrenheit(this KelvinInt input)
        {
            int.TryParse(
               Math.Round(Temperature.KelvinToFahrenheit(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this CelsiusInt input)
        {
            int.TryParse(
                Temperature.CelsiusToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this FahrenheitInt input)
        {
            int.TryParse(
                Temperature.FahrenheitToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this GasInt input)
        {
            int.TryParse(
                Temperature.GasToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToGas(this KelvinInt input)
        {
            int.TryParse(
                Temperature.KelvinToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this CelsiusInt input)
        {
            int.TryParse(
                Math.Round(Temperature.CelsiusToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this FahrenheitInt input)
        {
            int.TryParse(
                Math.Round(Temperature.FahrenheitToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this GasInt input)
        {
            int.TryParse(
                Math.Round(Temperature.GasToKelvin(input.Temperature)).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static int ToKelvin(this KelvinInt input)
        {
            int.TryParse(
                Temperature.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }
    }
}