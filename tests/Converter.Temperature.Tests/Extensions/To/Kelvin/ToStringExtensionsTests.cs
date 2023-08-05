namespace Converter.Temperature.Tests.Extensions.To.Kelvin;

using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Kelvin;
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
}
