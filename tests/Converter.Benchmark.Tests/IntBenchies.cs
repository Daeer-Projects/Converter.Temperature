// ReSharper disable ClassCanBeSealed.Global - Benchmark creates derived class.

namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Celsius;
using Temperature.Extensions.To.Fahrenheit;
using Temperature.Extensions.To.Gas;
using Temperature.Extensions.To.Kelvin;
using Temperature.Extensions.To.Rankine;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public class IntBenchies
{
    #region Celsius

    [Benchmark]
    public int ConvertFromCelsiusToCelsius()
    {
        const int input = 42;
        int result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToFahrenheit()
    {
        const int input = 42;
        int result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToGas()
    {
        const int input = 176;
        int result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToGasGeneric()
    {
        const int input = 176;
        int result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToKelvin()
    {
        const int input = 200;
        int result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToRankine()
    {
        const int input = 200;
        int result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public int ConvertFromCelsiusToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public int ConvertFromFahrenheitToCelsius()
    {
        const int input = 42;
        int result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToFahrenheit()
    {
        const int input = 42;
        int result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToGas()
    {
        const int input = 329;
        int result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToGasGeneric()
    {
        const int input = 329;
        int result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToKelvin()
    {
        const int input = 200;
        int result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToRankine()
    {
        const int input = 200;
        int result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public int ConvertFromFahrenheitToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public int ConvertFromKelvinToCelsius()
    {
        const int input = 42;
        int result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToFahrenheit()
    {
        const int input = 42;
        int result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToGas()
    {
        const int input = 473;
        int result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToGasGeneric()
    {
        const int input = 473;
        int result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToKelvin()
    {
        const int input = 200;
        int result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToRankine()
    {
        const int input = 200;
        int result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public int ConvertFromKelvinToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public int ConvertFromGasToCelsius()
    {
        const int input = 5;
        int result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToCelsiusGeneric()
    {
        const int input = 5;
        int result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToFahrenheit()
    {
        const int input = 6;
        int result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToFahrenheitGeneric()
    {
        const int input = 6;
        int result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToGas()
    {
        const int input = 6;
        int result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToGasGeneric()
    {
        const int input = 6;
        int result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToKelvin()
    {
        const int input = 2;
        int result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToKelvinGeneric()
    {
        const int input = 2;
        int result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToRankine()
    {
        const int input = 7;
        int result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public int ConvertFromGasToRankineGeneric()
    {
        const int input = 7;
        int result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public int ConvertFromRankineToCelsius()
    {
        const int input = 42;
        int result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToFahrenheit()
    {
        const int input = 42;
        int result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToGas()
    {
        const int input = 806;
        int result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToGasGeneric()
    {
        const int input = 806;
        int result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToKelvin()
    {
        const int input = 200;
        int result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToRankine()
    {
        const int input = 200;
        int result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public int ConvertFromRankineToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}
