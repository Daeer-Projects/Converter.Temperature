namespace Converter.Temperature.Tests.Extensions.To.Celsius;

using FluentAssertions;
using Temperature.Extensions.To;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class ToStringExtensionsTests
{
    [Fact]
    public void Test_to_celsius_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusString input = new("42");

        // Act.
        string result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_celsius_generic_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusString input = new("42");

        // Act.
        string result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_celsius_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "10";
        FahrenheitString input = new("50");

        // Act.
        string result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "10";
        FahrenheitString input = new("50");

        // Act.
        string result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "220";
        GasString input = new("7");

        // Act.
        string result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "220";
        GasString input = new("7");

        // Act.
        string result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "1";
        KelvinString input = new("274.15");

        // Act.
        string result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "1";
        KelvinString input = new("274.15");

        // Act.
        string result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "1.0000000000000062";
        RankineString input = new("493.47");

        // Act.
        string result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "1.0000000000000062";
        RankineString input = new("493.47");

        // Act.
        string result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
