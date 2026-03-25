using System;
using System.Collections.Generic;
using System.Globalization;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Rankine;

public sealed class ToStringExtensionsTests : BaseToExtensionTests<RankineString, string>
{
    public ToStringExtensionsTests() : base("99999.9999", GetData()) { }

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
        RankineString value,
        int fractionalCount)
    {
        return value.ToRankine(fractionalCount);
    }

    protected override string ToUsingGeneric(
        RankineString value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Rankine>(fractionalCount);
    }

    protected override RankineString Create(
        string value)
    {
        return new RankineString(value);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        CelsiusString input = new("200");

        // Act.
        string result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        CelsiusString input = new("200");

        // Act.
        string result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusString inputCelsius = new(input.ToString(CultureInfo.InvariantCulture));

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_rankine_generic_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusString inputCelsius = new(input.ToString(CultureInfo.InvariantCulture));

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<TemperatureTypes.Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_rankine_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.6700000000001";
        FahrenheitString input = new("392");

        // Act.
        string result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.6700000000001";
        FahrenheitString input = new("392");

        // Act.
        string result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        GasString input = new("6");

        // Act.
        string result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        GasString input = new("6");

        // Act.
        string result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_kelvin_returns_same_value()
    {
        // Arrange.
        const string expected = "851.67";
        KelvinString input = new("473.15");

        // Act.
        string result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        const string expected = "851.67";
        KelvinString input = new("473.15");

        // Act.
        string result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineString input = new("851.67");

        // Act.
        string result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rankine_generic_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineString input = new("851.67");

        // Act.
        string result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData("2157.8528571428574", "493.47")]
    [InlineData("1391.67", "270")]
    [InlineData("1193.67", "212.25")]
    [InlineData("1013.6700000000001", "159.75")]
    [InlineData("465.9557142857143", "0")]
    [InlineData("0", "-135.90375")]
    [InlineData("-10.4045142857143", "-138.9384")]
    public void Test_to_rankine_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("2157.8528571428574", "493.47")]
    [InlineData("1391.67", "270")]
    [InlineData("1193.67", "212.25")]
    [InlineData("1013.6700000000001", "159.75")]
    [InlineData("465.9557142857143", "0")]
    [InlineData("0", "-135.90375")]
    [InlineData("-10.4045142857143", "-138.9384")]
    public void Test_to_rankine_generic_from_rømer_returns_correct_value(
        string expected,
        string originalTemp)
    {
        // Arrange.
        RømerString input = new(originalTemp);

        // Act.
        string result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
