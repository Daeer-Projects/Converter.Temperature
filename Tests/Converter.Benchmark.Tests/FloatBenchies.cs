namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public sealed class FloatBenchies
{
    #region Celsius

    [Benchmark]
    public float ConvertFromCelsiusToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToGas()
    {
        const float input = 176.2598f;
        float result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToGasGeneric()
    {
        const float input = 176.2598f;
        float result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToKelvin()
    {
        const float input = 200f;
        float result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToRankine()
    {
        const float input = 200f;
        float result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public float ConvertFromCelsiusToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public float ConvertFromFahrenheitToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToGas()
    {
        const float input = 329.2598f;
        float result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToGasGeneric()
    {
        const float input = 329.2598f;
        float result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToKelvin()
    {
        const float input = 200f;
        float result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToRankine()
    {
        const float input = 200f;
        float result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public float ConvertFromFahrenheitToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public float ConvertFromKelvinToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToGas()
    {
        const float input = 473.2598f;
        float result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToGasGeneric()
    {
        const float input = 473.2598f;
        float result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToKelvin()
    {
        const float input = 200f;
        float result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToRankine()
    {
        const float input = 200f;
        float result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public float ConvertFromKelvinToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public float ConvertFromGasToCelsius()
    {
        const float input = 5.4756843f;
        float result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToCelsiusGeneric()
    {
        const float input = 5.4756843f;
        float result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToFahrenheit()
    {
        const float input = 6.4756843f;
        float result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToFahrenheitGeneric()
    {
        const float input = 6.4756843f;
        float result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToGas()
    {
        const float input = 6.2598f;
        float result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToGasGeneric()
    {
        const float input = 6.2598f;
        float result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToKelvin()
    {
        const float input = 2f;
        float result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToKelvinGeneric()
    {
        const float input = 2f;
        float result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToRankine()
    {
        const float input = 7f;
        float result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public float ConvertFromGasToRankineGeneric()
    {
        const float input = 7f;
        float result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public float ConvertFromRankineToCelsius()
    {
        const float input = 42.4756843f;
        float result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToCelsiusGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToFahrenheit()
    {
        const float input = 42.4756843f;
        float result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToFahrenheitGeneric()
    {
        const float input = 42.4756843f;
        float result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToGas()
    {
        const float input = 806.2598f;
        float result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToGasGeneric()
    {
        const float input = 806.2598f;
        float result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToKelvin()
    {
        const float input = 200f;
        float result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToKelvinGeneric()
    {
        const float input = 200f;
        float result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToRankine()
    {
        const float input = 200f;
        float result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public float ConvertFromRankineToRankineGeneric()
    {
        const float input = 200f;
        float result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}