namespace Converter.Temperature.Tests.Extensions.To.Fahrenheit;

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
using Xunit;

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
        return value.To<Fahrenheit>(fractionalCount);
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
}
