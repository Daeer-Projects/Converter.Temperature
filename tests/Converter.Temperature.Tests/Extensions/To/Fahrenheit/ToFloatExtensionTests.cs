namespace Converter.Temperature.Tests.Extensions.To.Fahrenheit;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Fahrenheit;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToFloatExtensionTests : BaseToExtensionTests<FahrenheitFloat, float>
{
    public ToFloatExtensionTests() : base(999.999f, GetData()) { }

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
        FahrenheitFloat value,
        int fractionalCount)
    {
        return value.ToFahrenheit(fractionalCount);
    }

    protected override float ToUsingGeneric(
        FahrenheitFloat value,
        int fractionalCount)
    {
        return value.To<Fahrenheit>(fractionalCount);
    }

    protected override FahrenheitFloat Create(
        float value)
    {
        return new FahrenheitFloat(value);
    }

    [Fact]
    public void Test_to_fahrenheit_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 53.6f;
        CelsiusFloat input = new(12);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 53.6f;
        CelsiusFloat input = new(12);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitFloat input = new(50.456f);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitFloat input = new(50.456f);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(50.5f, 1)]
    [InlineData(50.46f, 2)]
    public void Test_to_fahrenheit_with_round_parameter_from_fahrenheit_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        FahrenheitFloat input = new(50.456f);

        // Act.
        float result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(50.5f, 1)]
    [InlineData(50.46f, 2)]
    public void Test_to_fahrenheit_generic_parameter_from_fahrenheit_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        FahrenheitFloat input = new(50.456f);

        // Act.
        float result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 428f;
        GasFloat input = new(7);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 428f;
        GasFloat input = new(7);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.8f;
        KelvinFloat input = new(274.15f);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.8f;
        KelvinFloat input = new(274.15f);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_to_fahrenheit_from_kelvin_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        KelvinFloat inputKelvin = new(input);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputKelvin.ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_fahrenheit_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.800995f;
        RankineFloat input = new(493.471f);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.800995f;
        RankineFloat input = new(493.471f);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.8f, 1)]
    [InlineData(33.801f, 3)]
    public void Test_to_fahrenheit_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new(493.471f);

        // Act.
        float result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.8f, 1)]
    [InlineData(33.801f, 3)]
    public void Test_to_fahrenheit_generic_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new(493.471f);

        // Act.
        float result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1698.1828571428573f, 493.47f)]
    [InlineData(932f, 270f)]
    [InlineData(734f, 212.25f)]
    [InlineData(554f, 159.75f)]
    [InlineData(6.285715f, 0f)]
    [InlineData(-459.66998f, -135.90375f)]
    public void Test_to_fahrenheit_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1698.1828571428573f, 493.47f)]
    [InlineData(932f, 270f)]
    [InlineData(734f, 212.25f)]
    [InlineData(554f, 159.75f)]
    [InlineData(6.285715f, 0f)]
    [InlineData(-459.66998f, -135.90375f)]
    public void Test_to_fahrenheit_generic_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(6.3f, 1)]
    [InlineData(6.285715f, 14)]
    public void Test_to_fahrenheit_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(0f);

        // Act.
        float result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(6.3f, 1)]
    [InlineData(6.285715f, 14)]
    public void Test_to_fahrenheit_generic_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(0f);

        // Act.
        float result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
