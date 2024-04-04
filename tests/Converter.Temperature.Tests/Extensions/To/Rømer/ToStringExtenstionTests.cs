namespace Converter.Temperature.Tests.Extensions.To.Rømer;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Rømer;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToStringExtenstionTests : BaseToExtensionTests<RømerString, string>
{
    public ToStringExtenstionTests() : base("9999.99", GetData()) { }

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
        RømerString value,
        int fractionalCount)
    {
        return value.ToRømer(fractionalCount);
    }

    protected override string ToUsingGeneric(
        RømerString value,
        int fractionalCount)
    {
        return value.To<Rømer>(fractionalCount);
    }

    protected override RømerString Create(string value)
    {
        return new RømerString(value);
    }

    [Fact]
    public void Test_to_rømer_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        CelsiusString input = new("200");

        // Act.
        string result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        CelsiusString input = new("200");

        // Act.
        string result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        FahrenheitString input = new("392");

        // Act.
        string result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        FahrenheitString input = new("392");

        // Act.
        string result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        GasString input = new("6");

        // Act.
        string result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        GasString input = new("6");

        // Act.
        string result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        KelvinString input = new("473.15");

        // Act.
        string result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        KelvinString input = new("473.15");

        // Act.
        string result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.49999999999999";
        RankineString input = new("851.67");

        // Act.
        string result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.49999999999999";
        RankineString input = new("851.67");

        // Act.
        string result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerString input = new("851.67");

        // Act.
        string result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerString input = new("851.67");

        // Act.
        string result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}