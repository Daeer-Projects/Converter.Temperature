namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public class IntBenchies
{
    #region Celsius

    [Benchmark]
    public static int ConvertFromCelsiusToCelsius()
    {
        const int input = 42;
        int result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToFahrenheit()
    {
        const int input = 42;
        int result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToGas()
    {
        const int input = 176;
        int result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToGasGeneric()
    {
        const int input = 176;
        int result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToKelvin()
    {
        const int input = 200;
        int result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToRankine()
    {
        const int input = 200;
        int result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static int ConvertFromCelsiusToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public static int ConvertFromFahrenheitToCelsius()
    {
        const int input = 42;
        int result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToFahrenheit()
    {
        const int input = 42;
        int result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToGas()
    {
        const int input = 329;
        int result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToGasGeneric()
    {
        const int input = 329;
        int result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToKelvin()
    {
        const int input = 200;
        int result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToRankine()
    {
        const int input = 200;
        int result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static int ConvertFromFahrenheitToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public static int ConvertFromKelvinToCelsius()
    {
        const int input = 42;
        int result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToFahrenheit()
    {
        const int input = 42;
        int result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToGas()
    {
        const int input = 473;
        int result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToGasGeneric()
    {
        const int input = 473;
        int result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToKelvin()
    {
        const int input = 200;
        int result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToRankine()
    {
        const int input = 200;
        int result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static int ConvertFromKelvinToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public static int ConvertFromGasToCelsius()
    {
        const int input = 5;
        int result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToCelsiusGeneric()
    {
        const int input = 5;
        int result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToFahrenheit()
    {
        const int input = 6;
        int result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToFahrenheitGeneric()
    {
        const int input = 6;
        int result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToGas()
    {
        const int input = 6;
        int result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToGasGeneric()
    {
        const int input = 6;
        int result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToKelvin()
    {
        const int input = 2;
        int result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToKelvinGeneric()
    {
        const int input = 2;
        int result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToRankine()
    {
        const int input = 7;
        int result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static int ConvertFromGasToRankineGeneric()
    {
        const int input = 7;
        int result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public static int ConvertFromRankineToCelsius()
    {
        const int input = 42;
        int result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToCelsiusGeneric()
    {
        const int input = 42;
        int result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToFahrenheit()
    {
        const int input = 42;
        int result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToFahrenheitGeneric()
    {
        const int input = 42;
        int result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToGas()
    {
        const int input = 806;
        int result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToGasGeneric()
    {
        const int input = 806;
        int result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToKelvin()
    {
        const int input = 200;
        int result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToKelvinGeneric()
    {
        const int input = 200;
        int result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToRankine()
    {
        const int input = 200;
        int result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static int ConvertFromRankineToRankineGeneric()
    {
        const int input = 200;
        int result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}