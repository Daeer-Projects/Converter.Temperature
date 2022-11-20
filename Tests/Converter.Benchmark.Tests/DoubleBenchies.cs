// ReSharper disable ClassCanBeSealed.Global - Benchmark creates derived class.

namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public class DoubleBenchies
{
    #region Celsius

    [Benchmark]
    public double ConvertFromCelsiusToCelsius()
    {
        const double input = 42.4756843d;
        double result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToCelsiusGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToFahrenheit()
    {
        const double input = 42.4756843d;
        double result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToFahrenheitGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToGas()
    {
        const double input = 176.2598d;
        double result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToGasGeneric()
    {
        const double input = 176.2598d;
        double result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToKelvin()
    {
        const double input = 200d;
        double result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToKelvinGeneric()
    {
        const double input = 200d;
        double result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToRankine()
    {
        const double input = 200d;
        double result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public double ConvertFromCelsiusToRankineGeneric()
    {
        const double input = 200d;
        double result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public double ConvertFromFahrenheitToCelsius()
    {
        const double input = 42.4756843d;
        double result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToCelsiusGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToFahrenheit()
    {
        const double input = 42.4756843d;
        double result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToGas()
    {
        const double input = 329.2598d;
        double result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToGasGeneric()
    {
        const double input = 329.2598d;
        double result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToKelvin()
    {
        const double input = 200d;
        double result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToKelvinGeneric()
    {
        const double input = 200d;
        double result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToRankine()
    {
        const double input = 200d;
        double result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public double ConvertFromFahrenheitToRankineGeneric()
    {
        const double input = 200d;
        double result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public double ConvertFromKelvinToCelsius()
    {
        const double input = 42.4756843d;
        double result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToCelsiusGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToFahrenheit()
    {
        const double input = 42.4756843d;
        double result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToFahrenheitGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToGas()
    {
        const double input = 473.2598d;
        double result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToGasGeneric()
    {
        const double input = 473.2598d;
        double result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToKelvin()
    {
        const double input = 200d;
        double result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToKelvinGeneric()
    {
        const double input = 200d;
        double result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToRankine()
    {
        const double input = 200d;
        double result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public double ConvertFromKelvinToRankineGeneric()
    {
        const double input = 200d;
        double result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public double ConvertFromGasToCelsius()
    {
        const double input = 5.4756843d;
        double result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToCelsiusGeneric()
    {
        const double input = 5.4756843d;
        double result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToFahrenheit()
    {
        const double input = 6.4756843d;
        double result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToFahrenheitGeneric()
    {
        const double input = 6.4756843d;
        double result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToGas()
    {
        const double input = 6.2598d;
        double result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToGasGeneric()
    {
        const double input = 6.2598d;
        double result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToKelvin()
    {
        const double input = 2d;
        double result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToKelvinGeneric()
    {
        const double input = 2d;
        double result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToRankine()
    {
        const double input = 7d;
        double result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public double ConvertFromGasToRankineGeneric()
    {
        const double input = 7d;
        double result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public double ConvertFromRankineToCelsius()
    {
        const double input = 42.4756843d;
        double result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToCelsiusGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToFahrenheit()
    {
        const double input = 42.4756843d;
        double result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToFahrenheitGeneric()
    {
        const double input = 42.4756843d;
        double result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToGas()
    {
        const double input = 806.2598d;
        double result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToGasGeneric()
    {
        const double input = 806.2598d;
        double result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToKelvin()
    {
        const double input = 200d;
        double result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToKelvinGeneric()
    {
        const double input = 200d;
        double result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToRankine()
    {
        const double input = 200d;
        double result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public double ConvertFromRankineToRankineGeneric()
    {
        const double input = 200d;
        double result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}