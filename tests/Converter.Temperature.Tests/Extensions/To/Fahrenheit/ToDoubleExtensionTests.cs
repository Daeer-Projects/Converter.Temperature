﻿namespace Converter.Temperature.Tests.Extensions.To.Fahrenheit;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Fahrenheit;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToDoubleExtensionTests : BaseToExtensionTests<FahrenheitDouble, double>
{
    public ToDoubleExtensionTests() : base(999.999d, GetData()) { }

    private static List<double> GetData()
    {
        return new List<double>
        {
            999.999d,
            0d,
            -999.999
        };
    }

    protected override double To(
        FahrenheitDouble value,
        int fractionalCount)
    {
        return value.ToFahrenheit(fractionalCount);
    }

    protected override double ToUsingGeneric(
        FahrenheitDouble value,
        int fractionalCount)
    {
        return value.To<Fahrenheit>(fractionalCount);
    }

    protected override FahrenheitDouble Create(
        double value)
    {
        return new FahrenheitDouble(value);
    }

    [Fact]
    public void Test_to_fahrenheit_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 53.6d;
        CelsiusDouble input = new(12);

        // Act.
        double result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 53.6d;
        CelsiusDouble input = new(12);

        // Act.
        double result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_fahrenheit_generic_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_fahrenheit_from_fahrenheit_returns_same_value()
    {
        // Arrange.
        FahrenheitDouble input = new(50);

        // Act.
        double result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_fahrenheit_returns_same_value()
    {
        // Arrange.
        FahrenheitDouble input = new(50);

        // Act.
        double result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 428d;
        GasDouble input = new(7);

        // Act.
        double result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 428d;
        GasDouble input = new(7);

        // Act.
        double result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 33.8d;
        KelvinDouble input = new(274.15);

        // Act.
        double result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 33.8d;
        KelvinDouble input = new(274.15);

        // Act.
        double result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.8d, 1)]
    [InlineData(34d, 0)]
    public void Test_to_fahrenheit_with_parameter_from_kelvin_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        KelvinDouble input = new(274.15);

        // Act.
        double result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.8d, 1)]
    [InlineData(34d, 0)]
    public void Test_to_fahrenheit_generic_with_parameter_from_kelvin_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        KelvinDouble input = new(274.15);

        // Act.
        double result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 33.800999999999991d;
        RankineDouble input = new(493.471d);

        // Act.
        double result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 33.800999999999991d;
        RankineDouble input = new(493.471d);

        // Act.
        double result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.800999999999991d, -1)]
    [InlineData(34d, 0)]
    [InlineData(33.801d, 3)]
    public void Test_to_fahrenheit_with_parameter_from_rankine_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RankineDouble input = new(493.471d);

        // Act.
        double result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.800999999999991d, -1)]
    [InlineData(34d, 0)]
    [InlineData(33.801d, 3)]
    public void Test_to_fahrenheit_generic_with_parameter_from_rankine_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RankineDouble input = new(493.471d);

        // Act.
        double result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1698.1828571428573d, 493.47d)]
    [InlineData(932d, 270d)]
    [InlineData(734d, 212.25d)]
    [InlineData(554d, 159.75d)]
    [InlineData(6.285714285714285d, 0d)]
    [InlineData(-459.67d, -135.90375d)]
    public void Test_to_fahrenheit_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1698.1828571428573d, 493.47d)]
    [InlineData(932d, 270d)]
    [InlineData(734d, 212.25d)]
    [InlineData(554d, 159.75d)]
    [InlineData(6.285714285714285d, 0d)]
    [InlineData(-459.67d, -135.90375d)]
    public void Test_to_fahrenheit_generic_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(6.3d, 1)]
    [InlineData(6.28571428571428d, 14)]
    public void Test_to_fahrenheit_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(0d);

        // Act.
        double result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(6.3d, 1)]
    [InlineData(6.28571428571428d, 14)]
    public void Test_to_fahrenheit_generic_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(0d);

        // Act.
        double result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
