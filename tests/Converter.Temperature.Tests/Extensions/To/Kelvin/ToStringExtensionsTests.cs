namespace Converter.Temperature.Tests.Extensions.To.Kelvin;

using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Kelvin;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToStringExtensionsTests : BaseToExtensionTests<KelvinString, string>
{
    public ToStringExtensionsTests() : base("999.999", GetData()) { }

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
        KelvinString value,
        int fractionalCount)
    {
        return value.ToKelvin(fractionalCount);
    }

    protected override string ToUsingGeneric(
        KelvinString value,
        int fractionalCount)
    {
        return value.To<Kelvin>(fractionalCount);
    }

    protected override KelvinString Create(
        string value)
    {
        return new KelvinString(value);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        CelsiusString input = new("200");

        // Act.
        string result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        CelsiusString input = new("200");

        // Act.
        string result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        FahrenheitString input = new("392");

        // Act.
        string result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        FahrenheitString input = new("392");

        // Act.
        string result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        GasString input = new("6");

        // Act.
        string result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        GasString input = new("6");

        // Act.
        string result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinString input = new("473.15");

        // Act.
        string result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinString input = new("473.15");

        // Act.
        string result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.1499999999999";
        RankineString input = new("851.67");

        // Act.
        string result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.1499999999999";
        RankineString input = new("851.67");

        // Act.
        string result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("1198.807142857143", "493.47")]
    [InlineData("773.15", "270")]
    [InlineData("663.15", "212.25")]
    [InlineData("563.15", "159.75")]
    [InlineData("258.8642857142857", "0")]
    [InlineData("0", "-135.90375")]
    public void Test_to_kelvin_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("1198.807142857143", "493.47")]
    [InlineData("773.15", "270")]
    [InlineData("663.15", "212.25")]
    [InlineData("563.15", "159.75")]
    [InlineData("258.8642857142857", "0")]
    [InlineData("0", "-135.90375")]
    public void Test_to_kelvin_generic_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
