namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public class FloatBenchies
{
    #region Celsius

    [Benchmark]
    public static float ConvertFromCelsiusToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToGas()
    {
        const float input = 176.2598f;
        float result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToGasGeneric()
    {
        const float input = 176.2598f;
        float result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToKelvin()
    {
        const float input = 200f;
        float result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToRankine()
    {
        const float input = 200f;
        float result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static float ConvertFromCelsiusToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public static float ConvertFromFahrenheitToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToGas()
    {
        const float input = 329.2598f;
        float result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToGasGeneric()
    {
        const float input = 329.2598f;
        float result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToKelvin()
    {
        const float input = 200f;
        float result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToRankine()
    {
        const float input = 200f;
        float result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static float ConvertFromFahrenheitToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public static float ConvertFromKelvinToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToGas()
    {
        const float input = 473.2598f;
        float result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToGasGeneric()
    {
        const float input = 473.2598f;
        float result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToKelvin()
    {
        const float input = 200f;
        float result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToRankine()
    {
        const float input = 200f;
        float result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static float ConvertFromKelvinToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public static float ConvertFromGasToCelsius()
    {
        const float input = 5.4756843f;
        float result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToCelsiusGeneric()
    {
        const float input = 5.4756843f;
        float result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToFahrenheit()
    {
        const float input = 6.4756843f;
        float result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToFahrenheitGeneric()
    {
        const float input = 6.4756843f;
        float result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToGas()
    {
        const float input = 6.2598f;
        float result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToGasGeneric()
    {
        const float input = 6.2598f;
        float result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToKelvin()
    {
        const float input = 2f;
        float result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToKelvinGeneric()
    {
        const float input = 2f;
        float result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToRankine()
    {
        const float input = 7f;
        float result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static float ConvertFromGasToRankineGeneric()
    {
        const float input = 7f;
        float result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public static float ConvertFromRankineToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToGas()
    {
        const float input = 806.2598f;
        float result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToGasGeneric()
    {
        const float input = 806.2598f;
        float result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToKelvin()
    {
        const float input = 200f;
        float result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToRankine()
    {
        const float input = 200f;
        float result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static float ConvertFromRankineToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}