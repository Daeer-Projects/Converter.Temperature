﻿namespace Converter.Temperature.Integration.Tests.FloatTests;

using Extensions.From;
using Extensions.To;
using Extensions.To.Rankine;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToRankineFloatTests
{
    #region From Celsius

    [Fact]
    public void Test_float_extensions_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        const float input = 200f;

        // Act.
        float result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        const float input = 200f;

        // Act.
        float result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.69653f;
        const float input = 392.026531f;

        // Act.
        float result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.69653f;
        const float input = 392.026531f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(-1000f, -1800f)]
    [InlineData(0f, 0f)]
    [InlineData(50f, 90f)]
    [InlineData(1000f, 1800f)]
    public void Test_float_extension_from_kelvin_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -1800f)]
    [InlineData(0f, 0f)]
    [InlineData(50f, 90f)]
    [InlineData(1000f, 1800f)]
    public void Test_float_extension_generic_from_kelvin_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_float_extension_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        const float input = 6f;

        // Act.
        float result = input.FromGas()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extension_generic_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        const float input = 6f;

        // Act.
        float result = input.From<Gas>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(-345.65f)]
    [InlineData(0.0f)]
    [InlineData(7564.2334f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_and_to_rankine_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(-345.65f)]
    [InlineData(0.0f)]
    [InlineData(7564.2334f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_generic_from_and_to_rankine_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(-1000f, -2962.615714285714f)]
    [InlineData(0f, 465.9557142857143f)]
    [InlineData(50f, 637.3842857142857f)]
    [InlineData(100f, 808.8128571428572f)]
    [InlineData(500f, 2180.2414285714285f)]
    [InlineData(1000f, 3894.5271428571427f)]
    public void Test_float_extension_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -2962.615714285714f)]
    [InlineData(0f, 465.9557142857143f)]
    [InlineData(50f, 637.3842857142857f)]
    [InlineData(100f, 808.8128571428572f)]
    [InlineData(500f, 2180.2414285714285f)]
    [InlineData(1000f, 3894.5271428571427f)]
    public void Test_float_extension_generic_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -2962.615714285714f, -1)]
    [InlineData(0f, 465.9557142857143f, -1)]
    [InlineData(50f, 637.3842857142857f, -1)]
    [InlineData(100f, 808.8128571428572f, -1)]
    [InlineData(500f, 2180.2414285714285f, -1)]
    [InlineData(1000f, 3894.5271428571427f, -1)]
    [InlineData(-1000f, -2963f, 0)]
    [InlineData(0f, 466f, 0)]
    [InlineData(50f, 637f, 0)]
    [InlineData(100f, 809f, 0)]
    [InlineData(500f, 2180f, 0)]
    [InlineData(1000f, 3895f, 0)]
    [InlineData(-1000f, -2962.6f, 1)]
    [InlineData(0f, 465.9557142857143f, 13)]
    [InlineData(50f, 637.3843f, 4)]
    [InlineData(100f, 808.8f, 1)]
    [InlineData(500f, 2180.2414286f, 7)]
    [InlineData(1000f, 3894.527142857143f, 14)]
    public void Test_float_extension_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -2962.615714285714f, -1)]
    [InlineData(0f, 465.9557142857143f, -1)]
    [InlineData(50f, 637.3842857142857f, -1)]
    [InlineData(100f, 808.8128571428572f, -1)]
    [InlineData(500f, 2180.2414285714285f, -1)]
    [InlineData(1000f, 3894.5271428571427f, -1)]
    [InlineData(-1000f, -2963f, 0)]
    [InlineData(0f, 466f, 0)]
    [InlineData(50f, 637f, 0)]
    [InlineData(100f, 809f, 0)]
    [InlineData(500f, 2180f, 0)]
    [InlineData(1000f, 3895f, 0)]
    [InlineData(-1000f, -2962.6f, 1)]
    [InlineData(0f, 465.9557142857143f, 13)]
    [InlineData(50f, 637.3843f, 4)]
    [InlineData(100f, 808.8f, 1)]
    [InlineData(500f, 2180.2414286f, 7)]
    [InlineData(1000f, 3894.527142857143f, 14)]
    public void Test_float_extension_generic_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rømer
}
