namespace Converter.Temperature.Integration.Tests.FloatTests;

using Extensions.From;
using Extensions.To;
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
}
