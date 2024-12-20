﻿// ReSharper disable ClassCanBeSealed.Global - Benchmark creates derived class.

namespace Converter.Benchmark.Tests;

using BenchmarkDotNet.Attributes;
using Temperature.Extensions.From;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Celsius;
using Temperature.Extensions.To.Fahrenheit;
using Temperature.Extensions.To.Gas;
using Temperature.Extensions.To.Kelvin;
using Temperature.Extensions.To.Rankine;
using Temperature.Extensions.To.Rømer;
using Temperature.TemperatureTypes;

[MemoryDiagnoser]
public class LongBenchies
{
    #region Celsius

    [Benchmark]
    public long ConvertFromCelsiusToCelsius()
    {
        const long input = 42;
        long result = input.FromCelsius()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Celsius>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToFahrenheit()
    {
        const long input = 42;
        long result = input.FromCelsius()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Celsius>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToGas()
    {
        const long input = 176;
        long result = input.FromCelsius()
            .ToGas();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToGasGeneric()
    {
        const long input = 176;
        long result = input.From<Celsius>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToKelvin()
    {
        const long input = 200;
        long result = input.FromCelsius()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Celsius>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToRankine()
    {
        const long input = 200;
        long result = input.FromCelsius()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Celsius>()
            .To<Rankine>();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToRømer()
    {
        const long input = 200;
        long result = input.FromCelsius()
            .ToRømer();
        return result;
    }

    [Benchmark]
    public long ConvertFromCelsiusToRømerGeneric()
    {
        const long input = 200;
        long result = input.From<Celsius>()
            .To<Rømer>();
        return result;
    }

    #endregion Celsius

    #region Fahrenheit

    [Benchmark]
    public long ConvertFromFahrenheitToCelsius()
    {
        const long input = 42;
        long result = input.FromFahrenheit()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Fahrenheit>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToFahrenheit()
    {
        const long input = 42;
        long result = input.FromFahrenheit()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Fahrenheit>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToGas()
    {
        const long input = 329;
        long result = input.FromFahrenheit()
            .ToGas();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToGasGeneric()
    {
        const long input = 329;
        long result = input.From<Fahrenheit>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToKelvin()
    {
        const long input = 200;
        long result = input.FromFahrenheit()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Fahrenheit>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToRankine()
    {
        const long input = 200;
        long result = input.FromFahrenheit()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Fahrenheit>()
            .To<Rankine>();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToRømer()
    {
        const long input = 200;
        long result = input.FromFahrenheit()
            .ToRømer();
        return result;
    }

    [Benchmark]
    public long ConvertFromFahrenheitToRømerGeneric()
    {
        const long input = 200;
        long result = input.From<Fahrenheit>()
            .To<Rømer>();
        return result;
    }

    #endregion Fahrenheit

    #region Kelvin

    [Benchmark]
    public long ConvertFromKelvinToCelsius()
    {
        const long input = 42;
        long result = input.FromKelvin()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Kelvin>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToFahrenheit()
    {
        const long input = 42;
        long result = input.FromKelvin()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Kelvin>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToGas()
    {
        const long input = 473;
        long result = input.FromKelvin()
            .ToGas();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToGasGeneric()
    {
        const long input = 473;
        long result = input.From<Kelvin>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToKelvin()
    {
        const long input = 200;
        long result = input.FromKelvin()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Kelvin>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToRankine()
    {
        const long input = 200;
        long result = input.FromKelvin()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Kelvin>()
            .To<Rankine>();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToRømer()
    {
        const long input = 200;
        long result = input.FromKelvin()
            .ToRømer();
        return result;
    }

    [Benchmark]
    public long ConvertFromKelvinToRømerGeneric()
    {
        const long input = 200;
        long result = input.From<Kelvin>()
            .To<Rømer>();
        return result;
    }

    #endregion Kelvin

    #region Gas

    [Benchmark]
    public long ConvertFromGasToCelsius()
    {
        const long input = 5;
        long result = input.FromGas()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToCelsiusGeneric()
    {
        const long input = 5;
        long result = input.From<Gas>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToFahrenheit()
    {
        const long input = 6;
        long result = input.FromGas()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToFahrenheitGeneric()
    {
        const long input = 6;
        long result = input.From<Gas>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToGas()
    {
        const long input = 6;
        long result = input.FromGas()
            .ToGas();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToGasGeneric()
    {
        const long input = 6;
        long result = input.From<Gas>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToKelvin()
    {
        const long input = 2;
        long result = input.FromGas()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToKelvinGeneric()
    {
        const long input = 2;
        long result = input.From<Gas>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToRankine()
    {
        const long input = 7;
        long result = input.FromGas()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToRankineGeneric()
    {
        const long input = 7;
        long result = input.From<Gas>()
            .To<Rankine>();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToRømer()
    {
        const long input = 7;
        long result = input.FromGas()
            .ToRømer();
        return result;
    }

    [Benchmark]
    public long ConvertFromGasToRømerGeneric()
    {
        const long input = 7;
        long result = input.From<Gas>()
            .To<Rømer>();
        return result;
    }

    #endregion Gas

    #region Rankine

    [Benchmark]
    public long ConvertFromRankineToCelsius()
    {
        const long input = 42;
        long result = input.FromRankine()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Rankine>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToFahrenheit()
    {
        const long input = 42;
        long result = input.FromRankine()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Rankine>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToGas()
    {
        const long input = 806;
        long result = input.FromRankine()
            .ToGas();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToGasGeneric()
    {
        const long input = 806;
        long result = input.From<Rankine>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToKelvin()
    {
        const long input = 200;
        long result = input.FromRankine()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Rankine>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToRankine()
    {
        const long input = 200;
        long result = input.FromRankine()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Rankine>()
            .To<Rankine>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToRømer()
    {
        const long input = 200;
        long result = input.FromRankine()
            .ToRømer();
        return result;
    }

    [Benchmark]
    public long ConvertFromRankineToRømerGeneric()
    {
        const long input = 200;
        long result = input.From<Rankine>()
            .To<Rømer>();
        return result;
    }

    #endregion Rankine

    #region Rømer

    [Benchmark]
    public long ConvertFromRømerToCelsius()
    {
        const long input = 42;
        long result = input.FromRømer()
            .ToCelsius();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToCelsiusGeneric()
    {
        const long input = 42;
        long result = input.From<Rømer>()
            .To<Celsius>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToFahrenheit()
    {
        const long input = 42;
        long result = input.FromRømer()
            .ToFahrenheit();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToFahrenheitGeneric()
    {
        const long input = 42;
        long result = input.From<Rømer>()
            .To<Fahrenheit>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToGas()
    {
        const long input = 806;
        long result = input.FromRømer()
            .ToGas();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToGasGeneric()
    {
        const long input = 806;
        long result = input.From<Rømer>()
            .To<Gas>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToKelvin()
    {
        const long input = 200;
        long result = input.FromRømer()
            .ToKelvin();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToKelvinGeneric()
    {
        const long input = 200;
        long result = input.From<Rømer>()
            .To<Kelvin>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToRankine()
    {
        const long input = 200;
        long result = input.FromRømer()
            .ToRankine();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToRankineGeneric()
    {
        const long input = 200;
        long result = input.From<Rømer>()
            .To<Rankine>();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToRømer()
    {
        const long input = 200;
        long result = input.FromRømer()
            .ToRømer();
        return result;
    }

    [Benchmark]
    public long ConvertFromRømerToRømerGeneric()
    {
        const long input = 200;
        long result = input.From<Rømer>()
            .To<Rømer>();
        return result;
    }

    #endregion Rømer
}
