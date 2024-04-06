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

public sealed class ToFloatExtensionTests : BaseToExtensionTests<RømerFloat, float>
{
    public ToFloatExtensionTests() : base(999.9999f, GetData()) { }

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
        RømerFloat value,
        int fractionalCount)
    {
        return value.ToRømer(fractionalCount);
    }

    protected override float ToUsingGeneric(
        RømerFloat value,
        int fractionalCount)
    {
        return value.To<Rømer>(fractionalCount);
    }

    protected override RømerFloat Create(
        float value)
    {
        return new RømerFloat(value);
    }

    [Fact]
    public void Test_to_rømer_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        CelsiusFloat input = new(200);

        // Act.
        float result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        CelsiusFloat input = new(200);

        // Act.
        float result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_to_rømer_from_celsius_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        CelsiusFloat inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRømer());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_to_rømer_generic_from_celsius_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        CelsiusFloat inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Rømer>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_rømer_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        FahrenheitFloat input = new(392);

        // Act.
        float result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        FahrenheitFloat input = new(392);

        // Act.
        float result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        GasFloat input = new(6);

        // Act.
        float result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        GasFloat input = new(6);

        // Act.
        float result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        KelvinFloat input = new(473.15f);

        // Act.
        float result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        KelvinFloat input = new(473.15f);

        // Act.
        float result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.49999f;
        RankineFloat input = new(851.67f);

        // Act.
        float result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.49999f;
        RankineFloat input = new(851.67f);

        // Act.
        float result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerFloat input = new(851.67f);

        // Act.
        float result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerFloat input = new(851.67f);

        // Act.
        float result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
