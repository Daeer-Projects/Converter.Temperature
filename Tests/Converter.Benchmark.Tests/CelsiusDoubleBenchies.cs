namespace Converter.Benchmark.Tests
{
    using BenchmarkDotNet.Attributes;
    using Temperature.Extensions.From;
    using Temperature.Extensions.To;
    using Temperature.TemperatureTypes;

    [MemoryDiagnoser]
    public class CelsiusDoubleBenchies
    {
        [Benchmark]
        public double ConvertFromCelsiusToFahrenheit()
        {
            const double input = 42.4756843d;
            double result = input.FromCelsius().ToFahrenheit();
            return result;
        }

        [Benchmark]
        public double ConvertFromCelsiusToFahrenheitGeneric()
        {
            const double input = 42.4756843d;
            double result = input.From<Celsius>().To<Fahrenheit>();
            return result;
        }
    }
}
