namespace Converter.Temperature.Tests.Extensions.To.Celsius;

using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class ToStringExtensionsTests : BaseToExtensionTests<CelsiusString, string>
{
    public ToStringExtensionsTests() : base("9999", GetData()) { }

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
        CelsiusString value,
        int fractionalCount)
    {
        return value.ToCelsius(fractionalCount);
    }

    protected override string ToUsingGeneric(
        CelsiusString value,
        int fractionalCount)
    {
        return value.To<Celsius>(fractionalCount);
    }

    protected override CelsiusString Create(
        string value)
    {
        return new CelsiusString(value);
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
