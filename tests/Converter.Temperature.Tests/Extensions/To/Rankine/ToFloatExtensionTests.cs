﻿namespace Converter.Temperature.Tests.Extensions.To.Rankine;

using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Rankine;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class ToFloatExtensionTests : BaseToExtensionTests<RankineFloat, float>
{
    public ToFloatExtensionTests() : base(999999.999999f, GetData()) { }

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
        RankineFloat value,
        int fractionalCount)
    {
        return value.ToRankine(fractionalCount);
    }

    protected override float ToUsingGeneric(
        RankineFloat value,
        int fractionalCount)
    {
        return value.To<Rankine>(fractionalCount);
    }

    protected override RankineFloat Create(
        float value)
    {
        return new RankineFloat(value);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        CelsiusFloat input = new(200);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        CelsiusFloat input = new(200);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        FahrenheitFloat input = new(392);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        FahrenheitFloat input = new(392);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        GasFloat input = new(6);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        GasFloat input = new(6);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_kelvin_returns_same_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        KelvinFloat input = new(473.15f);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        KelvinFloat input = new(473.15f);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineFloat input = new(851.67f);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rankine_generic_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineFloat input = new(851.67f);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
