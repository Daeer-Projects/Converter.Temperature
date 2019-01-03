using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.From
{
    public static class FromFloatExtensions
    {
        public static CelsiusFloat FromCelsius(this float input)
        {
            return new CelsiusFloat(input);
        }

        public static FahrenheitFloat FromFahrenheit(this float input)
        {
            return new FahrenheitFloat(input);
        }

        public static GasFloat FromGas(this float input)
        {
            return new GasFloat(input);
        }

        public static KelvinFloat FromKelvin(this float input)
        {
            return new KelvinFloat(input);
        }
    }
}