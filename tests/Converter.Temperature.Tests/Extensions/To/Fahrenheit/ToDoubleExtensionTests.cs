namespace Converter.Temperature.Tests.Extensions.To.Fahrenheit;

using System;
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

public sealed class ToDoubleExtensionTests
{
    [Fact]
    public void Test_to_fahrenheit_from_rømer_returns_correct_value()
    {
        // Arrange.
        const double expected = 932d;
        RømerDouble input = new(270d);

        // Act.
        double result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
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
    public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(double input)
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
    public void Test_to_fahrenheit_generic_from_celsius_with_invalid_parameter_throws_exception(double input)
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
}