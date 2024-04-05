namespace Converter.Temperature.Integration.Tests.FloatTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Gas;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToGasFloatTests
{
    #region From Celsius

    [Fact]
    public void Test_float_extensions_from_celsius_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 200f;

        // Act.
        float result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 200f;

        // Act.
        float result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(80f, 0.25f)]
    [InlineData(114f, 0.25f)]
    [InlineData(115f, 0.5f)]
    [InlineData(134f, 0.5f)]
    [InlineData(135f, 1f)]
    [InlineData(144f, 1f)]
    [InlineData(145f, 2f)]
    [InlineData(154f, 2f)]
    [InlineData(155f, 3f)]
    [InlineData(174f, 3f)]
    [InlineData(175f, 4f)]
    [InlineData(184f, 4f)]
    [InlineData(185f, 5f)]
    [InlineData(194f, 5f)]
    [InlineData(195f, 6f)]
    [InlineData(209f, 6f)]
    [InlineData(210f, 7f)]
    [InlineData(224f, 7f)]
    [InlineData(225f, 8f)]
    [InlineData(234f, 8f)]
    [InlineData(235f, 9f)]
    [InlineData(244f, 9f)]
    [InlineData(245f, 10f)]
    [InlineData(269f, 10f)]
    public void Test_float_extensions_from_celsius_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(80f, 0.25f)]
    [InlineData(114f, 0.25f)]
    [InlineData(115f, 0.5f)]
    [InlineData(134f, 0.5f)]
    [InlineData(135f, 1f)]
    [InlineData(144f, 1f)]
    [InlineData(145f, 2f)]
    [InlineData(154f, 2f)]
    [InlineData(155f, 3f)]
    [InlineData(174f, 3f)]
    [InlineData(175f, 4f)]
    [InlineData(184f, 4f)]
    [InlineData(185f, 5f)]
    [InlineData(194f, 5f)]
    [InlineData(195f, 6f)]
    [InlineData(209f, 6f)]
    [InlineData(210f, 7f)]
    [InlineData(224f, 7f)]
    [InlineData(225f, 8f)]
    [InlineData(234f, 8f)]
    [InlineData(235f, 9f)]
    [InlineData(244f, 9f)]
    [InlineData(245f, 10f)]
    [InlineData(269f, 10f)]
    public void Test_float_extensions_generic_from_celsius_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const float input = 74536.9876f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const float input = 74536.9876f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Celsius>()
                .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Theory]
    [InlineData(79f, "Temp too low for gas mark!")]
    [InlineData(270f, "Temp too high for gas mark!")]
    public void Test_float_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        float input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(79f, "Temp too low for gas mark!")]
    [InlineData(270f, "Temp too high for gas mark!")]
    public void Test_float_extensions_generic_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        float input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Celsius>()
                .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 392f;

        // Act.
        float result = input.FromFahrenheit()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 392f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_float_extensions_from_kelvin_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 473.15f;

        // Act.
        float result = input.FromKelvin()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_kelvin_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 473.15f;

        // Act.
        float result = input.From<Kelvin>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData(0.25f)]
    [InlineData(3f)]
    [InlineData(5f)]
    [InlineData(8f)]
    [InlineData(10f)]
    public void Test_float_extension_from_and_to_gas_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromGas()
            .ToGas();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(0.25f)]
    [InlineData(3f)]
    [InlineData(5f)]
    [InlineData(8f)]
    [InlineData(10f)]
    public void Test_float_extension_generic_from_and_to_gas_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.From<Gas>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extension_from_and_to_gas_throws_exception(
        float value)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => value.FromGas()
                .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extension_generic_from_and_to_gas_throws_exception(
        float value)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => value.From<Gas>()
                .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    #endregion From Gas

    #region From Rankine

    [Fact]
    public void Test_float_extensions_from_rankine_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 3f;
        const float input = 806.67f;

        // Act.
        float result = input.FromRankine()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_rankine_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 3f;
        const float input = 806.67f;

        // Act.
        float result = input.From<Rankine>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 405.2368f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromRankine()
                .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 405.2368f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Rankine>()
                .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 1002.89786f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromRankine()
                .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 1002.89786f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Rankine>()
                .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(49.5d, 0.25d)]
    [InlineData(67.35d, 0.25d)]
    [InlineData(67.875d, 0.5d)]
    [InlineData(77.85d, 0.5d)]
    [InlineData(78.375d, 1d)]
    [InlineData(83.1d, 1d)]
    [InlineData(83.625d, 2d)]
    [InlineData(88.35d, 2d)]
    [InlineData(88.875d, 3d)]
    [InlineData(98.85d, 3d)]
    [InlineData(99.375d, 4d)]
    [InlineData(104.1d, 4d)]
    [InlineData(104.63d, 5d)]
    [InlineData(109.35d, 5d)]
    [InlineData(109.88d, 6d)]
    [InlineData(117.23d, 6d)]
    [InlineData(117.75d, 7d)]
    [InlineData(125.1d, 7d)]
    [InlineData(125.63d, 8d)]
    [InlineData(130.35d, 8d)]
    [InlineData(130.88d, 9d)]
    [InlineData(135.6d, 9d)]
    [InlineData(136.13d, 10d)]
    [InlineData(148.73d, 10d)]
    public void Test_float_extensions_from_rømer_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRømer()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(49.5d, 0.25d)]
    [InlineData(67.35d, 0.25d)]
    [InlineData(67.875d, 0.5d)]
    [InlineData(77.85d, 0.5d)]
    [InlineData(78.375d, 1d)]
    [InlineData(83.1d, 1d)]
    [InlineData(83.625d, 2d)]
    [InlineData(88.35d, 2d)]
    [InlineData(88.875d, 3d)]
    [InlineData(98.85d, 3d)]
    [InlineData(99.375d, 4d)]
    [InlineData(104.1d, 4d)]
    [InlineData(104.63d, 5d)]
    [InlineData(109.35d, 5d)]
    [InlineData(109.88d, 6d)]
    [InlineData(117.23d, 6d)]
    [InlineData(117.75d, 7d)]
    [InlineData(125.1d, 7d)]
    [InlineData(125.63d, 8d)]
    [InlineData(130.35d, 8d)]
    [InlineData(130.88d, 9d)]
    [InlineData(135.6d, 9d)]
    [InlineData(136.13d, 10d)]
    [InlineData(148.73d, 10d)]
    public void Test_float_extensions_generic_from_rømer_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Rømer>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 48.975f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromRømer()
                .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 48.975f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Rømer>()
                .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 149.25f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromRømer()
                .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 149.25f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Rømer>()
                .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    #endregion From Rømer
}
