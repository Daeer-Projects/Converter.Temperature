namespace Converter.Temperature.Integration.Tests.DoubleTests;

using System;
using Extensions.From;
using Extensions.To;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToKelvinDoubleTests
{
    #region From Celsius

    [Fact]
    public void Test_double_extensions_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        double input)
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
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        double input)
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
    public void Test_double_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_and_to_kelvin_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.FromKelvin()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_generic_from_and_to_kelvin_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.From<Kelvin>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_double_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000d, -555.5555555555555d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 27.77777777777778d)]
    [InlineData(100d, 55.55555555555556d)]
    [InlineData(500d, 277.77777777777777d)]
    [InlineData(1000d, 555.5555555555555d)]
    public void Test_double_extension_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 27.77777777777778d)]
    [InlineData(100d, 55.55555555555556d)]
    [InlineData(500d, 277.77777777777777d)]
    [InlineData(1000d, 555.5555555555555d)]
    public void Test_double_extension_generic_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555d, -1)]
    [InlineData(0d, 0d, -1)]
    [InlineData(50d, 27.77777777777778d, -1)]
    [InlineData(100d, 55.55555555555556d, -1)]
    [InlineData(500d, 277.77777777777777d, -1)]
    [InlineData(1000d, 555.5555555555555d, -1)]
    [InlineData(-1000d, -556d, 0)]
    [InlineData(0d, 0d, 0)]
    [InlineData(50d, 28d, 0)]
    [InlineData(100d, 56d, 0)]
    [InlineData(500d, 278d, 0)]
    [InlineData(1000d, 556d, 0)]
    [InlineData(-1000d, -555.6d, 1)]
    [InlineData(50d, 27.7777777777778d, 13)]
    [InlineData(100d, 55.5556d, 4)]
    [InlineData(500d, 277.8d, 1)]
    [InlineData(1000d, 555.5555556d, 7)]
    public void Test_double_extension_with_parameter_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555d, -1)]
    [InlineData(0d, 0d, -1)]
    [InlineData(50d, 27.77777777777778d, -1)]
    [InlineData(100d, 55.55555555555556d, -1)]
    [InlineData(500d, 277.77777777777777d, -1)]
    [InlineData(1000d, 555.5555555555555d, -1)]
    [InlineData(-1000d, -556d, 0)]
    [InlineData(0d, 0d, 0)]
    [InlineData(50d, 28d, 0)]
    [InlineData(100d, 56d, 0)]
    [InlineData(500d, 278d, 0)]
    [InlineData(1000d, 556d, 0)]
    [InlineData(-1000d, -555.6d, 1)]
    [InlineData(50d, 27.7777777777778d, 13)]
    [InlineData(100d, 55.5556d, 4)]
    [InlineData(500d, 277.8d, 1)]
    [InlineData(1000d, 555.5555556d, 7)]
    public void Test_double_extension_generic_with_parameter_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine
}
