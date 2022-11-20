namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public class LongBenchies
{
    #region Celsius

    [Benchmark]
    public static long ConvertFromCelsiusToCelsius()
    {
        const long input = 42;
        long result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToFahrenheit()
    {
        const long input = 42;
        long result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToGas()
    {
        const long input = 176;
        long result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToGasGeneric()
    {
        const long input = 176;
        long result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToKelvin()
    {
        const long input = 200;
        long result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToRankine()
    {
        const long input = 200;
        long result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static long ConvertFromCelsiusToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public static long ConvertFromFahrenheitToCelsius()
    {
        const long input = 42;
        long result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToFahrenheit()
    {
        const long input = 42;
        long result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToGas()
    {
        const long input = 329;
        long result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToGasGeneric()
    {
        const long input = 329;
        long result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToKelvin()
    {
        const long input = 200;
        long result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToRankine()
    {
        const long input = 200;
        long result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static long ConvertFromFahrenheitToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public static long ConvertFromKelvinToCelsius()
    {
        const long input = 42;
        long result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToFahrenheit()
    {
        const long input = 42;
        long result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToGas()
    {
        const long input = 473;
        long result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToGasGeneric()
    {
        const long input = 473;
        long result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToKelvin()
    {
        const long input = 200;
        long result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToRankine()
    {
        const long input = 200;
        long result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static long ConvertFromKelvinToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public static long ConvertFromGasToCelsius()
    {
        const long input = 5;
        long result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToCelsiusGeneric()
    {
        const long input = 5;
        long result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToFahrenheit()
    {
        const long input = 6;
        long result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToFahrenheitGeneric()
    {
        const long input = 6;
        long result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToGas()
    {
        const long input = 6;
        long result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToGasGeneric()
    {
        const long input = 6;
        long result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToKelvin()
    {
        const long input = 2;
        long result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToKelvinGeneric()
    {
        const long input = 2;
        long result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToRankine()
    {
        const long input = 7;
        long result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static long ConvertFromGasToRankineGeneric()
    {
        const long input = 7;
        long result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public static long ConvertFromRankineToCelsius()
    {
        const long input = 42;
        long result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToFahrenheit()
    {
        const long input = 42;
        long result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToGas()
    {
        const long input = 806;
        long result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToGasGeneric()
    {
        const long input = 806;
        long result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToKelvin()
    {
        const long input = 200;
        long result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToRankine()
    {
        const long input = 200;
        long result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static long ConvertFromRankineToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}