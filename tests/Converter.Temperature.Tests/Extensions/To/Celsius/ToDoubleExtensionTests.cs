﻿namespace Converter.Temperature.Tests.Extensions.To.Celsius;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Celsius;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToDoubleExtensionTests : BaseToExtensionTests<CelsiusDouble, double>
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
        CelsiusDouble value,
        int fractionalCount)
    {
        return value.ToCelsius(fractionalCount);
    }

    protected override double ToUsingGeneric(
        CelsiusDouble value,
        int fractionalCount)
    {
        return value.To<Celsius>(fractionalCount);
    }

    protected override CelsiusDouble Create(
        double value)
    {
        return new CelsiusDouble(value);
    }

    [Fact]
    public void Test_to_celsius_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 10d;
        FahrenheitDouble input = new(50.0d);

        // Act.
        double result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 10d;
        FahrenheitDouble input = new(50.0d);

        // Act.
        double result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.25d, 125d)]
    [InlineData(0.9d, 125d)]
    [InlineData(1d, 140d)]
    [InlineData(1.4d, 140d)]
    [InlineData(1.5d, 150d)]
    [InlineData(2.4d, 150d)]
    [InlineData(2.5d, 165d)]
    [InlineData(3.4d, 165d)]
    [InlineData(3.5d, 180d)]
    [InlineData(4.4d, 180d)]
    [InlineData(4.5d, 190d)]
    [InlineData(5.4d, 190d)]
    [InlineData(5.5d, 200d)]
    [InlineData(6.4d, 200d)]
    [InlineData(6.5d, 220d)]
    [InlineData(7.4d, 220d)]
    [InlineData(7.5d, 230d)]
    [InlineData(8.4d, 230d)]
    [InlineData(8.5d, 240d)]
    [InlineData(9.4d, 240d)]
    [InlineData(9.5d, 260d)]
    [InlineData(9.9d, 260d)]
    public void Test_to_celsius_from_gas_returns_correct_value(
        double input,
        double expected)
    {
        // Arrange.
        GasDouble inputGas = new(input);

        // Act.
        double result = inputGas.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.25d, 125d)]
    [InlineData(0.9d, 125d)]
    [InlineData(1d, 140d)]
    [InlineData(1.4d, 140d)]
    [InlineData(1.5d, 150d)]
    [InlineData(2.4d, 150d)]
    [InlineData(2.5d, 165d)]
    [InlineData(3.4d, 165d)]
    [InlineData(3.5d, 180d)]
    [InlineData(4.4d, 180d)]
    [InlineData(4.5d, 190d)]
    [InlineData(5.4d, 190d)]
    [InlineData(5.5d, 200d)]
    [InlineData(6.4d, 200d)]
    [InlineData(6.5d, 220d)]
    [InlineData(7.4d, 220d)]
    [InlineData(7.5d, 230d)]
    [InlineData(8.4d, 230d)]
    [InlineData(8.5d, 240d)]
    [InlineData(9.4d, 240d)]
    [InlineData(9.5d, 260d)]
    [InlineData(9.9d, 260d)]
    public void Test_to_celsius_generic_from_gas_returns_correct_value(
        double input,
        double expected)
    {
        // Arrange.
        GasDouble inputGas = new(input);

        // Act.
        double result = inputGas.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_to_celsius_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(
        double input)
    {
        // Arrange.
        GasDouble inputGas = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_to_celsius_generic_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(
        double input)
    {
        // Arrange.
        GasDouble inputGas = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Fact]
    public void Test_to_celsius_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 1.0d;
        KelvinDouble input = new(274.15);

        // Act.
        double result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 1.0d;
        KelvinDouble input = new(274.15);

        // Act.
        double result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 1.0000000000000062d;
        RankineDouble input = new(493.47d);

        // Act.
        double result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 1.0000000000000062d;
        RankineDouble input = new(493.47d);

        // Act.
        double result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1.0d, 1)]
    [InlineData(1.00000000000001d, 14)]
    public void Test_to_celsius_with_parameter_from_rankine_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RankineDouble input = new(493.47d);

        // Act.
        double result = input.ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1.0d, 1)]
    [InlineData(1.00000000000001d, 14)]
    public void Test_to_celsius_generic_with_parameter_from_rankine_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RankineDouble input = new(493.47d);

        // Act.
        double result = input.To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.657142857143d, 493.47d)]
    [InlineData(500d, 270d)]
    [InlineData(390d, 212.25d)]
    [InlineData(290d, 159.75d)]
    [InlineData(-14.285714285714286d, 0d)]
    [InlineData(-273.15d, -135.90375d)]
    public void Test_to_celsius_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.657142857143d, 493.47d)]
    [InlineData(500d, 270d)]
    [InlineData(390d, 212.25d)]
    [InlineData(290d, 159.75d)]
    [InlineData(-14.285714285714286d, 0d)]
    [InlineData(-273.15d, -135.90375d)]
    public void Test_to_celsius_generic_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.7d, 1)]
    [InlineData(925.65714285714282d, 14)]
    public void Test_to_celsius_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(493.47d);

        // Act.
        double result = input.ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.7d, 1)]
    [InlineData(925.65714285714282d, 14)]
    public void Test_to_celsius_generic_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(493.47d);

        // Act.
        double result = input.To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
