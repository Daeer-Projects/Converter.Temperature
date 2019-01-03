using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.From
{
    public static class FromStringExtensions
    {
        public static CelsiusString FromCelsius(this string input)
        {
            return new CelsiusString(input);
        }

        public static FahrenheitString FromFahrenheit(this string input)
        {
            return new FahrenheitString(input);
        }

        public static GasString FromGas(this string input)
        {
            return new GasString(input);
        }

        public static KelvinString FromKelvin(this string input)
        {
            return new KelvinString(input);
        }
    }
}