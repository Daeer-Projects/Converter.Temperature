using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;

namespace Converter.Temperature.Extensions.From
{
    public static class FromDoubleExtensions
    {
        public static CelsiusDouble FromCelsius(this double input)
        {
            return new CelsiusDouble(input);
        }

        public static FahrenheitDouble FromFahrenheit(this double input)
        {
            return new FahrenheitDouble(input);
        }

        public static GasDouble FromGas(this double input)
        {
            return new GasDouble(input);
        }

        public static KelvinDouble FromKelvin(this double input)
        {
            return new KelvinDouble(input);
        }
    }
}