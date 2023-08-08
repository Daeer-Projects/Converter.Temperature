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
using Xunit;

public sealed class ToIntExtensionTests
{
    [Fact]
    public void Test_to_fahrenheit_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 54;
        CelsiusInt input = new(12);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 54;
        CelsiusInt input = new(12);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        CelsiusInt inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_to_fahrenheit_generic_from_celsius_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        CelsiusInt inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitInt input = new(50);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitInt input = new(50);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 446;
        GasInt input = new(7);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 446;
        GasInt input = new(7);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 34;
        KelvinInt input = new(274);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 34;
        KelvinInt input = new(274);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = -186;
        RankineInt input = new(274);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = -186;
        RankineInt input = new(274);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
