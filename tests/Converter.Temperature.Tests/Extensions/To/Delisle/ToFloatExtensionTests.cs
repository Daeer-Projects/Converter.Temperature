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

public sealed class ToFloatExtensionTests : BaseToExtensionTests<DelisleFloat, float>
{
    public ToFloatExtensionTests() : base(9999.999f, GetData()) { }

    private static List<float> GetData()
    {
        return new List<float>
        {
            999.999f,
            0f,
            -999.999f
        };
    }

    protected override float To(
        DelisleFloat value,
        int fractionalCount)
    {
        return value.ToDelisle(fractionalCount);
    }

    protected override float ToUsingGeneric(
        DelisleFloat value,
        int fractionalCount)
    {
        return value.To<Delisle>(fractionalCount);
    }

    protected override DelisleFloat Create(
        float value)
    {
        return new DelisleFloat(value);
    }

    [Fact]
    public void Test_to_delisle_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 150f;
        CelsiusFloat input = new(0f);

        // Act.
        float result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 150f;
        CelsiusFloat input = new(0f);

        // Act.
        float result = input.To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 150f;
        FahrenheitFloat input = new(32f);

        // Act.
        float result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 150f;
        FahrenheitFloat input = new(32f);

        // Act.
        float result = input.To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = -150f;
        GasFloat input = new(6f);

        // Act.
        float result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 150f;
        KelvinFloat input = new(273.15f);

        // Act.
        float result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 150f;
        RankineFloat input = new(491.67f);

        // Act.
        float result = input.ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.001f);
    }

    [Fact]
    public void Test_to_delisle_from_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 150f;
        RømerFloat input = new(7.5f);

        // Act.
        float result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_delisle_returns_same_value()
    {
        // Arrange.
        DelisleFloat input = new(150f);

        // Act.
        float result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
