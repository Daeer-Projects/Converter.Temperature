namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public class StringBenchies
{
    #region Celsius

    [Benchmark]
    public static string ConvertFromCelsiusToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToGas()
    {
        const string input = "176.2598";
        string result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToGasGeneric()
    {
        const string input = "176.2598";
        string result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToKelvin()
    {
        const string input = "200";
        string result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToRankine()
    {
        const string input = "200";
        string result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static string ConvertFromCelsiusToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public static string ConvertFromFahrenheitToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToGas()
    {
        const string input = "329.2598";
        string result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToGasGeneric()
    {
        const string input = "329.2598";
        string result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToKelvin()
    {
        const string input = "200";
        string result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToRankine()
    {
        const string input = "200";
        string result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static string ConvertFromFahrenheitToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public static string ConvertFromKelvinToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToGas()
    {
        const string input = "473.2598";
        string result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToGasGeneric()
    {
        const string input = "473.2598";
        string result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToKelvin()
    {
        const string input = "200";
        string result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToRankine()
    {
        const string input = "200";
        string result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static string ConvertFromKelvinToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public static string ConvertFromGasToCelsius()
    {
        const string input = "5.4756843";
        string result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToCelsiusGeneric()
    {
        const string input = "5.4756843";
        string result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToFahrenheit()
    {
        const string input = "6.4756843";
        string result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToFahrenheitGeneric()
    {
        const string input = "6.4756843";
        string result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToGas()
    {
        const string input = "6.2598";
        string result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToGasGeneric()
    {
        const string input = "6.2598";
        string result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToKelvin()
    {
        const string input = "2";
        string result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToKelvinGeneric()
    {
        const string input = "2";
        string result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToRankine()
    {
        const string input = "7";
        string result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static string ConvertFromGasToRankineGeneric()
    {
        const string input = "7";
        string result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public static string ConvertFromRankineToCelsius()
    {
        const string input = "42.4756843";
        string result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToCelsiusGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToFahrenheit()
    {
        const string input = "42.4756843";
        string result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToFahrenheitGeneric()
    {
        const string input = "42.4756843";
        string result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToGas()
    {
        const string input = "806.2598";
        string result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToGasGeneric()
    {
        const string input = "806.2598";
        string result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToKelvin()
    {
        const string input = "200";
        string result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToKelvinGeneric()
    {
        const string input = "200";
        string result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToRankine()
    {
        const string input = "200";
        string result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public static string ConvertFromRankineToRankineGeneric()
    {
        const string input = "200";
        string result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    #endregion Rankine
}