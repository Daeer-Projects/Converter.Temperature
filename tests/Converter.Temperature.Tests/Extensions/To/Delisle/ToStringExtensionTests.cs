namespace Converter.Temperature.Tests.Extensions.To.Delisle;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Delisle;
using TemperatureTypes;
using Types.Celsius;
using Types.Delisle;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToStringExtensionTests : BaseToExtensionTests<DelisleString, string>
{
    public ToStringExtensionTests() : base(9999.999d.ToString("R"), GetData()) { }

    private static List<string> GetData()
    {
        return new List<string>
        {
            999.999d.ToString("R"),
            0d.ToString("R"),
            (-999.999d).ToString("R")
        };
    }

    protected override string To(
        DelisleString value,
        int fractionalCount)
    {
        return value.ToDelisle(fractionalCount);
    }

    protected override string ToUsingGeneric(
        DelisleString value,
        int fractionalCount)
    {
        return value.To<Delisle>(fractionalCount);
    }

    protected override DelisleString Create(
        string value)
    {
        return new DelisleString(value);
    }

    [Fact]
    public void Test_to_delisle_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "150";
        CelsiusString input = new("0");

        // Act.
        string result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "150";
        CelsiusString input = new("0");

        // Act.
        string result = input.To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "150";
        FahrenheitString input = new("32");

        // Act.
        string result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "150";
        FahrenheitString input = new("32");

        // Act.
        string result = input.To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "-150";
        GasString input = new("6");

        // Act.
        string result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "150";
        KelvinString input = new("273.15");

        // Act.
        string result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "150";
        RankineString input = new("491.67");

        // Act.
        string result = input.ToDelisle();

        // Assert.
        double resultDouble = double.Parse(result);
        double expectedDouble = double.Parse(expected);
        resultDouble.Should()
            .BeApproximately(expectedDouble, 0.00000000001d);
    }

    [Fact]
    public void Test_to_delisle_from_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "150";
        RømerString input = new("7.5");

        // Act.
        string result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_delisle_returns_same_value()
    {
        // Arrange.
        DelisleString input = new("150");

        // Act.
        string result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
