namespace Converter.Temperature.Tests.Extensions.To.Fahrenheit;

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

public sealed class ToStringExtensionsTests
{
    [Fact]
    public void Test_to_fahrenheit_from_celsius_returns_same_value()
    {
        // Arrange.
        const string expected = "53.6";
        CelsiusString input = new("12");

        // Act.
        string result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_celsius_returns_same_value()
    {
        // Arrange.
        const string expected = "53.6";
        CelsiusString input = new("12");

        // Act.
        string result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitString input = new("50");

        // Act.
        string result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitString input = new("50");

        // Act.
        string result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "428";
        GasString input = new("7");

        // Act.
        string result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "428";
        GasString input = new("7");

        // Act.
        string result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "33.8";
        KelvinString input = new("274.15");

        // Act.
        string result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "33.8";
        KelvinString input = new("274.15");

        // Act.
        string result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "33.80099999999999";
        RankineString input = new("493.471");

        // Act.
        string result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "33.80099999999999";
        RankineString input = new("493.471");

        // Act.
        string result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("1698.1828571428573", "493.47")]
    [InlineData("932", "270")]
    [InlineData("734", "212.25")]
    [InlineData("554", "159.75")]
    [InlineData("6.285714285714285", "0")]
    [InlineData("-459.67", "-135.90375")]
    public void Test_to_fahrenheit_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("1698.1828571428573", "493.47")]
    [InlineData("932", "270")]
    [InlineData("734", "212.25")]
    [InlineData("554", "159.75")]
    [InlineData("6.285714285714285", "0")]
    [InlineData("-459.67", "-135.90375")]
    public void Test_to_fahrenheit_generic_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}