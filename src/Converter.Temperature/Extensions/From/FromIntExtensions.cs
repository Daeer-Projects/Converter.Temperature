using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.From
{
    public static class FromIntExtensions
    {
        public static CelsiusInt FromCelsius(this int input)
        {
            return new CelsiusInt(input);
        }

        public static FahrenheitInt FromFahrenheit(this int input)
        {
            return new FahrenheitInt(input);
        }

        public static GasInt FromGas(this int input)
        {
            return new GasInt(input);
        }

        public static KelvinInt FromKelvin(this int input)
        {
            return new KelvinInt(input);
        }
    }
}