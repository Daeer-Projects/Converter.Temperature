using System;
using System.Globalization;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.To
{
    public static class ToFloatExtensions
    {
        public static float ToCelsius(this CelsiusFloat input)
        {
            float.TryParse(
                Temperature.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToCelsius(this FahrenheitFloat input)
        {
            var result = input.Temperature;
            if (float.TryParse(
                Temperature.FahrenheitToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp))
            {
                result = convertedTemp;
            }
            return result;
        }

        public static float ToCelsius(this GasFloat input)
        {
            float.TryParse(
                Temperature.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToCelsius(this KelvinFloat input)
        {
            float.TryParse(
                Temperature.KelvinToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return (float)Math.Round(convertedTemp, 2);
        }

        public static float ToFahrenheit(this CelsiusFloat input)
        {
            float.TryParse(
                Temperature.CelsiusToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return convertedTemp;
        }

        public static float ToFahrenheit(this FahrenheitFloat input)
        {
            float.TryParse(
                Temperature.FahrenheitToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToFahrenheit(this GasFloat input)
        {
            float.TryParse(
                Temperature.GasToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToFahrenheit(this KelvinFloat input)
        {
            float.TryParse(
                Temperature.KelvinToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);

            if (float.IsInfinity(convertedTemp)) throw new ArgumentOutOfRangeException(Constants.ValueOutOfRangeForType);

            return (float)Math.Round(convertedTemp, 2);
        }

        public static float ToGas(this CelsiusFloat input)
        {
            float.TryParse(
                Temperature.CelsiusToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToGas(this FahrenheitFloat input)
        {
            float.TryParse(
                Temperature.FahrenheitToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToGas(this GasFloat input)
        {
            float.TryParse(
                Temperature.GasToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToGas(this KelvinFloat input)
        {
            float.TryParse(
                Temperature.KelvinToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this CelsiusFloat input)
        {
            float.TryParse(
                Temperature.CelsiusToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this FahrenheitFloat input)
        {
            float.TryParse(
                Temperature.FahrenheitToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this GasFloat input)
        {
            float.TryParse(
                Temperature.GasToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this KelvinFloat input)
        {
            float.TryParse(
                Temperature.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out var convertedTemp);
            return convertedTemp;
        }
    }
}