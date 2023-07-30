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
public class StringBenchies
{
    #region Celsius

    [Benchmark]
    public string ConvertFromCelsiusToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToGas()
    {
        const string input = "176.2598";
        string result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToGasGeneric()
    {
        const string input = "176.2598";
        string result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToKelvin()
    {
        const string input = "200";
        string result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToRankine()
    {
        const string input = "200";
        string result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public string ConvertFromCelsiusToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public string ConvertFromFahrenheitToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToGas()
    {
        const string input = "329.2598";
        string result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToGasGeneric()
    {
        const string input = "329.2598";
        string result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToKelvin()
    {
        const string input = "200";
        string result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToRankine()
    {
        const string input = "200";
        string result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public string ConvertFromFahrenheitToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public string ConvertFromKelvinToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToGas()
    {
        const string input = "473.2598";
        string result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToGasGeneric()
    {
        const string input = "473.2598";
        string result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToKelvin()
    {
        const string input = "200";
        string result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToRankine()
    {
        const string input = "200";
        string result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public string ConvertFromKelvinToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public string ConvertFromGasToCelsius()
    {
        const string input = "5.4756843";
        string result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToCelsiusGeneric()
    {
        const string input = "5.4756843";
        string result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToFahrenheit()
    {
        const string input = "6.4756843";
        string result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToFahrenheitGeneric()
    {
        const string input = "6.4756843";
        string result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToGas()
    {
        const string input = "6.2598";
        string result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToGasGeneric()
    {
        const string input = "6.2598";
        string result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToKelvin()
    {
        const string input = "2";
        string result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToKelvinGeneric()
    {
        const string input = "2";
        string result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToRankine()
    {
        const string input = "7";
        string result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public string ConvertFromGasToRankineGeneric()
    {
        const string input = "7";
        string result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public string ConvertFromRankineToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToGas()
    {
        const string input = "806.2598";
        string result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToGasGeneric()
    {
        const string input = "806.2598";
        string result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToKelvin()
    {
        const string input = "200";
        string result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToRankine()
    {
        const string input = "200";
        string result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public string ConvertFromRankineToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}