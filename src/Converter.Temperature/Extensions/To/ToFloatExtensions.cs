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
            var convertedTemp = input.Temperature;
            float.TryParse(
                Temperature.CelsiusToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToCelsius(this FahrenheitFloat input)
        {
            var result = input.Temperature;
            var convertedTemp = 0f;
            if (float.TryParse(
                Temperature.FahrenheitToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp))
            {
                result = convertedTemp;
            }
            return result;
        }

        public static float ToCelsius(this GasFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.GasToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToCelsius(this KelvinFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.KelvinToCelsius(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToFahrenheit(this CelsiusFloat input)
        {
            var experimentalTemp = Temperature.CelsiusToFahrenheit(input.Temperature);

            if (experimentalTemp > float.MaxValue || experimentalTemp < float.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            var result = (float) experimentalTemp;

            return result;
        }

        public static float ToFahrenheit(this FahrenheitFloat input)
        {
            var convertedTemp = input.Temperature;
            float.TryParse(
                Temperature.FahrenheitToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToFahrenheit(this GasFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.GasToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToFahrenheit(this KelvinFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.KelvinToFahrenheit(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToGas(this CelsiusFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.CelsiusToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToGas(this FahrenheitFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.FahrenheitToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToGas(this GasFloat input)
        {
            var convertedTemp = input.Temperature;
            float.TryParse(
                Temperature.GasToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToGas(this KelvinFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.KelvinToGas(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this CelsiusFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.CelsiusToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this FahrenheitFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.FahrenheitToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this GasFloat input)
        {
            var convertedTemp = 0f;
            float.TryParse(
                Temperature.GasToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }

        public static float ToKelvin(this KelvinFloat input)
        {
            var convertedTemp = input.Temperature;
            float.TryParse(
                Temperature.KelvinToKelvin(input.Temperature).ToString(CultureInfo.InvariantCulture),
                out convertedTemp);
            return convertedTemp;
        }
    }
}