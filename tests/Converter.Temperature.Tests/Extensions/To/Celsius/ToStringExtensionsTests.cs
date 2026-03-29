using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Celsius;

public sealed class ToStringExtensionsTests : BaseToExtensionTests<CelsiusString, string>
{
    public ToStringExtensionsTests() : base("9999", GetData()) { }

    private static List<string> GetData()
    {
        return ["999.999", "0", "-999.999"];
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
        return value.To<TemperatureTypes.Celsius>(fractionalCount);
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
        string result = input.To<TemperatureTypes.Celsius>();

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
        string result = input.To<TemperatureTypes.Celsius>();

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
        string result = input.To<TemperatureTypes.Celsius>();

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
        string result = input.To<TemperatureTypes.Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("925.657142857143", "493.47")]
    [InlineData("500", "270")]
    [InlineData("390", "212.25")]
    [InlineData("290", "159.75")]
    [InlineData("-14.285714285714286", "0")]
    [InlineData("-273.15", "-135.90375")]
    public void Test_to_celsius_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("925.657142857143", "493.47")]
    [InlineData("500", "270")]
    [InlineData("390", "212.25")]
    [InlineData("290", "159.75")]
    [InlineData("-14.285714285714286", "0")]
    [InlineData("-273.15", "-135.90375")]
    public void Test_to_celsius_generic_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.To<TemperatureTypes.Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
