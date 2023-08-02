namespace Converter.Temperature.Tests.Extensions.To.Celsius;

using System;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Celsius;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToFloatExtensionTests
{
    [Fact]
    public void Test_to_celsius_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusFloat input = new(42);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_celsius_generic_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusFloat input = new(42.3f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_celsius_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 10f;
        FahrenheitFloat input = new(50);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 10f;
        FahrenheitFloat input = new(50.0f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 220f;
        GasFloat input = new(7.0f);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.25f, 125f)]
    [InlineData(0.9f, 125f)]
    [InlineData(1f, 140f)]
    [InlineData(1.4f, 140f)]
    [InlineData(1.5f, 150f)]
    [InlineData(2.4f, 150f)]
    [InlineData(2.5f, 165f)]
    [InlineData(3.4f, 165f)]
    [InlineData(3.5f, 180f)]
    [InlineData(4.4f, 180f)]
    [InlineData(4.5f, 190f)]
    [InlineData(5.4f, 190f)]
    [InlineData(5.5f, 200f)]
    [InlineData(6.4f, 200f)]
    [InlineData(6.5f, 220f)]
    [InlineData(7.4f, 220f)]
    [InlineData(7.5f, 230f)]
    [InlineData(8.4f, 230f)]
    [InlineData(8.5f, 240f)]
    [InlineData(9.4f, 240f)]
    [InlineData(9.5f, 260f)]
    [InlineData(9.9f, 260f)]
    public void Test_to_celsius_generic_from_gas_returns_correct_value(
        float input,
        float expected)
    {
        // Arrange.
        GasFloat inputGas = new(input);

        // Act.
        float result = inputGas.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_to_celsius_generic_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(
        float input)
    {
        // Arrange.
        GasFloat inputGas = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Fact]
    public void Test_to_celsius_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 1f;
        KelvinFloat input = new(274.15f);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 1f;
        KelvinFloat input = new(274.15f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2.7f, 1)]
    [InlineData(2.711304f, 6)]
    public void Test_to_celsius_with_parameter_from_kelvin_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        KelvinFloat input = new(275.8612978f);

        // Act.
        float result = input.ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2.7f, 1)]
    [InlineData(2.711304f, 6)]
    public void Test_to_celsius_generic_with_parameter_from_kelvin_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        KelvinFloat input = new(275.8612978f);

        // Act.
        float result = input.To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 0.9999932f;
        RankineFloat input = new(493.47f);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 0.9999932f;
        RankineFloat input = new(493.47f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1.0f, 1)]
    [InlineData(0.999993f, 6)]
    public void Test_to_celsius_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new(493.47f);

        // Act.
        float result = input.ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1.0f, 1)]
    [InlineData(0.999993f, 6)]
    public void Test_to_celsius_generic_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new(493.47f);

        // Act.
        float result = input.To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.657142857143f, 493.47f)]
    [InlineData(500f, 270f)]
    [InlineData(390f, 212.25f)]
    [InlineData(290f, 159.75f)]
    [InlineData(-14.285714285714286f, 0f)]
    [InlineData(-273.15f, -135.90375f)]
    public void Test_to_celsius_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.657142857143f, 493.47f)]
    [InlineData(500f, 270f)]
    [InlineData(390f, 212.25f)]
    [InlineData(290f, 159.75f)]
    [InlineData(-14.285714285714286f, 0f)]
    [InlineData(-273.15f, -135.90375f)]
    public void Test_to_celsius_generic_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.7f, 1)]
    [InlineData(925.65714285714282f, 14)]
    public void Test_to_celsius_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(493.47f);

        // Act.
        float result = input.ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925.7f, 1)]
    [InlineData(925.65714285714282f, 14)]
    public void Test_to_celsius_generic_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(493.47f);

        // Act.
        float result = input.To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}