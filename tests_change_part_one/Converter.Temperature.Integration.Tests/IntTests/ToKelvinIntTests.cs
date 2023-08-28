namespace Converter.Temperature.Integration.Tests.IntTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Kelvin;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToKelvinIntTests
{
    #region From Celsius

    [Theory]
    [InlineData(200, 473)]
    public void Test_int_extensions_from_celsius_to_kelvin_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(200, 473)]
    public void Test_int_extensions_generic_from_celsius_to_kelvin_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Celsius>()
                .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0.0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_and_to_kelvin_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromKelvin()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0.0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_generic_from_and_to_kelvin_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.From<Kelvin>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_int_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 490;
        const int input = 6;

        // Act.
        int result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 490;
        const int input = 6;

        // Act.
        int result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000, -555)]
    [InlineData(0, 0)]
    [InlineData(50, 27)]
    [InlineData(100, 55)]
    [InlineData(500, 277)]
    [InlineData(1000, 555)]
    public void Test_int_extension_from_rankine_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -555)]
    [InlineData(0, 0)]
    [InlineData(50, 27)]
    [InlineData(100, 55)]
    [InlineData(500, 277)]
    [InlineData(1000, 555)]
    public void Test_int_extension_generic_from_rankine_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine
}
