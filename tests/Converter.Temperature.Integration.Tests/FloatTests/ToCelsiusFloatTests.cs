namespace Converter.Temperature.Integration.Tests.FloatTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Celsius;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToCelsiusFloatTests
{
    #region From Celsius

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(-345.65f)]
    [InlineData(0.0f)]
    [InlineData(7564.2334f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_and_to_celsius_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromCelsius()
            .ToCelsius();

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
    public void Test_float_extension_generic_from_and_to_celsius_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.From<Celsius>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_to_fahrenheit_from_kelvin_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromFahrenheit()
                .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_to_fahrenheit_from_kelvin_generic_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Fahrenheit>()
                .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_celsius_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 10f;
        const float input = 50f;

        // Act.
        float result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_celsius_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 10f;
        const float input = 50f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_float_extensions_from_kelvin_to_celsius_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 1.0189514f;
        const float input = 274.168932972f;

        // Act.
        float result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_kelvin_to_celsius_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 1.0189514f;
        const float input = 274.168932972f;

        // Act.
        float result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_float_value()
    {
        // Arrange.
        const float expected = float.MinValue;
        const float input = float.MinValue;

        // Act.
        float result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_float_value()
    {
        // Arrange.
        const float expected = float.MinValue;
        const float input = float.MinValue;

        // Act.
        float result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

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
    public void Test_float_extensions_from_gas_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromGas()
            .ToCelsius();

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
    public void Test_float_extensions_generic_from_gas_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Gas>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromGas()
                .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Gas>()
                .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(0f, -273.15002f)]
    [InlineData(-100f, -328.70557f)]
    [InlineData(100f, -217.59445f)]
    [InlineData(1000f, 282.40555f)]
    public void Test_float_extension_from_rankine_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRankine()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0f, -273.15002f)]
    [InlineData(-100f, -328.70557f)]
    [InlineData(100f, -217.59445f)]
    [InlineData(1000f, 282.40555f)]
    public void Test_float_extension_generic_from_rankine_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Rankine>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0f, -273.15002f, -1)]
    [InlineData(-100f, -328.70557f, -1)]
    [InlineData(-100f, -328.7f, 1)]
    [InlineData(-100f, -328.7056f, 4)]
    [InlineData(100f, -217.59445f, -1)]
    [InlineData(100f, -217.6f, 1)]
    [InlineData(100f, -217.594f, 3)]
    [InlineData(1000f, 282.40555f, -1)]
    [InlineData(1000f, 282.4f, 1)]
    [InlineData(1000f, 282.41f, 2)]
    public void Test_float_extension_from_rankine_with_parameter_to_celsius_returns_correct_float_value(
        float input,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = input.FromRankine()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0f, -273.15002f, -1)]
    [InlineData(-100f, -328.70557f, -1)]
    [InlineData(-100f, -328.7f, 1)]
    [InlineData(-100f, -328.7056f, 4)]
    [InlineData(100f, -217.59445f, -1)]
    [InlineData(100f, -217.6f, 1)]
    [InlineData(100f, -217.594f, 3)]
    [InlineData(1000f, 282.40555f, -1)]
    [InlineData(1000f, 282.4f, 1)]
    [InlineData(1000f, 282.41f, 2)]
    public void Test_float_extension_generic_from_rankine_with_parameter_to_celsius_returns_correct_float_value(
        float input,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = input.From<Rankine>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_rankine_to_celsius_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromRankine()
                .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_generic_from_rankine_to_celsius_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Rankine>()
                .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Rankine
}
