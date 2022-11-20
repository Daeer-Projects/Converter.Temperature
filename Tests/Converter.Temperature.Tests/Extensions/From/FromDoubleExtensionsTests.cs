﻿namespace Converter.Temperature.Tests.Extensions.From;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public class FromDoubleExtensionsTests
{
    [Fact]
    public void Test_from_celsius_returns_celsius_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        CelsiusDouble result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        FahrenheitDouble result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_returns_gas_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        GasDouble result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        KelvinDouble result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        RankineDouble result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}