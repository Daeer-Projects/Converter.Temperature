using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Fahrenheit;

public sealed class ToStringExtensionsTests : BaseToExtensionTests<FahrenheitString, string>
{
    public ToStringExtensionsTests() : base("9999.99", GetData()) { }

    private static List<string> GetData()
    {
        return new List<string>
        {
            "999.999",
            "0",
            "-999.999"
        };
    }

    protected override string To(
        FahrenheitString value,
        int fractionalCount)
    {
        return value.ToFahrenheit(fractionalCount);
    }

    protected override string ToUsingGeneric(
        FahrenheitString value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Fahrenheit>(fractionalCount);
    }

    protected override FahrenheitString Create(
        string value)
    {
        return new FahrenheitString(value);
    }

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
        string result = input.To<TemperatureTypes.Fahrenheit>();

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
        string result = input.To<TemperatureTypes.Fahrenheit>();

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
        string result = input.To<TemperatureTypes.Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "33.799999999999955";
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
        const string expected = "33.799999999999955";
        KelvinString input = new("274.15");

        // Act.
        string result = input.To<TemperatureTypes.Fahrenheit>();

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
        string result = input.To<TemperatureTypes.Fahrenheit>();

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
        string result = input.To<TemperatureTypes.Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
