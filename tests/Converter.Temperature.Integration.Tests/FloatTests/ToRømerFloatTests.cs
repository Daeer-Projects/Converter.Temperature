namespace Converter.Temperature.Integration.Tests.FloatTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Rømer;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToRømerFloatTests
{
    #region From Celsius

    [Fact]
    public void Test_float_extensions_from_celsius_to_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 200f;

        // Act.
        float result = input.FromCelsius()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 200f;

        // Act.
        float result = input.From<Celsius>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.07d, 2)]
    public void Test_float_extensions_with_parameter_from_celsius_to_rømer_returns_correct_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 203f;

        // Act.
        float result = input.FromCelsius()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.07d, 2)]
    public void Test_float_extensions_generic_with_parameter_from_celsius_to_rømer_returns_correct_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 203f;

        // Act.
        float result = input.From<Celsius>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extensions_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToRømer());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extensions_generic_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Celsius>()
                .To<Rømer>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 392f;

        // Act.
        float result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 392f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_float_extensions_with_parameter_from_fahrenheit_to_rømer_returns_correct_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 392.94f;

        // Act.
        float result = input.FromFahrenheit()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_float_extensions_generic_with_parameter_from_fahrenheit_to_rømer_returns_correct_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 392.94f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(-1000d, -660.9037500000001f)]
    [InlineData(0d, -135.90375f)]
    [InlineData(50d, -109.65374999999999f)]
    [InlineData(1000d, 389.09625f)]
    public void Test_float_extension_from_kelvin_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -660.9037500000001f)]
    [InlineData(0d, -135.90375f)]
    [InlineData(50d, -109.65374999999999f)]
    [InlineData(1000d, 389.09625f)]
    public void Test_float_extension_generic_from_kelvin_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_float_extension_from_gas_to_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 6f;

        // Act.
        float result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extension_generic_from_gas_to_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 6f;

        // Act.
        float result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_float_extension_with_parameter_from_gas_to_rømer_returns_correct_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 6f;

        // Act.
        float result = input.FromGas()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_float_extension_generic_with_parameter_from_gas_to_rømer_returns_correct_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 6f;

        // Act.
        float result = input.From<Gas>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000f, -427.57043f)]
    [InlineData(0f, -135.90376f)]
    [InlineData(50f, -121.32041666666666f)]
    [InlineData(100f, -106.73709f)]
    [InlineData(500f, 9.92958f)]
    [InlineData(1000f, 155.76291f)]
    public void Test_float_extension_from_rankine_and_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -427.57043f)]
    [InlineData(0f, -135.90376f)]
    [InlineData(50f, -121.32041666666666f)]
    [InlineData(100f, -106.73709f)]
    [InlineData(500f, 9.92958f)]
    [InlineData(1000f, 155.76291f)]
    public void Test_float_extension_generic_from_rankine_and_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -427.57043f, -1)]
    [InlineData(0f, -135.90376f, -1)]
    [InlineData(50f, -121.32041666666666f, -1)]
    [InlineData(100f, -106.73709f, -1)]
    [InlineData(500f, 9.92958f, -1)]
    [InlineData(1000f, 155.76291f, -1)]
    [InlineData(-1000f, -428f, 0)]
    [InlineData(0f, -136f, 0)]
    [InlineData(50f, -121f, 0)]
    [InlineData(100f, -107f, 0)]
    [InlineData(500f, 10f, 0)]
    [InlineData(1000f, 156f, 0)]
    [InlineData(-1000f, -427.6f, 1)]
    [InlineData(0f, -135.90376f, 13)]
    [InlineData(50f, -121.3204f, 4)]
    [InlineData(100f, -106.7f, 1)]
    [InlineData(500f, 9.92958f, 7)]
    [InlineData(1000f, 155.76291f, 14)]
    public void Test_float_extension_with_parameter_from_rankine_and_to_rømer_returns_correct_float_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToRømer(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -427.57043f, -1)]
    [InlineData(0f, -135.90376f, -1)]
    [InlineData(50f, -121.32041666666666f, -1)]
    [InlineData(100f, -106.73709f, -1)]
    [InlineData(500f, 9.92958f, -1)]
    [InlineData(1000f, 155.76291f, -1)]
    [InlineData(-1000f, -428f, 0)]
    [InlineData(0f, -136f, 0)]
    [InlineData(50f, -121f, 0)]
    [InlineData(100f, -107f, 0)]
    [InlineData(500f, 10f, 0)]
    [InlineData(1000f, 156f, 0)]
    [InlineData(-1000f, -427.6f, 1)]
    [InlineData(0f, -135.90376f, 13)]
    [InlineData(50f, -121.3204f, 4)]
    [InlineData(100f, -106.7f, 1)]
    [InlineData(500f, 9.92958f, 7)]
    [InlineData(1000f, 155.76291f, 14)]
    public void Test_float_extension_generic_with_parameter_from_rankine_and_to_rømer_returns_correct_float_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Rømer>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(-345.65f)]
    [InlineData(0.0f)]
    [InlineData(7564.2334f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_and_to_rømer_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToRømer();

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
    public void Test_float_extension_generic_from_and_to_rømer_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Rømer
}
