namespace Converter.Temperature.Integration.Tests.DoubleTests;

using System;
using Extensions.From;
using Extensions.To;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToFahrenheitDoubleTests
{
    #region From Celsius

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_generic_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Celsius>()
                .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-152436784.334563d, -274386179.8022134d)]
    [InlineData(0.0d, 32.0d)]
    [InlineData(26431662.73648262d, 47577024.925668716d)]
    public void Test_double_extension_from_celsius_and_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-152436784.334563d, -274386179.8022134d)]
    [InlineData(0.0d, 32.0d)]
    [InlineData(26431662.73648262d, 47577024.925668716d)]
    public void Test_double_extension_generic_from_celsius_and_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Celsius>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-152436784.334563d, -274386179.8022134d, -1)]
    [InlineData(0.0d, 32.0d, -1)]
    [InlineData(26431662.73648262d, 47577024.925668716d, -1)]
    [InlineData(-152436784.334563d, -274386180d, 0)]
    [InlineData(0.0d, 32d, 0)]
    [InlineData(26431662.73648262d, 47577025d, 0)]
    [InlineData(-152436784.334563d, -274386179.802d, 3)]
    [InlineData(0.0d, 32.0d, 1)]
    [InlineData(26431662.73648262d, 47577024.92567d, 5)]
    public void Test_double_extension_with_parameter_from_celsius_and_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-152436784.334563d, -274386179.8022134d, -1)]
    [InlineData(0.0d, 32.0d, -1)]
    [InlineData(26431662.73648262d, 47577024.925668716d, -1)]
    [InlineData(-152436784.334563d, -274386180d, 0)]
    [InlineData(0.0d, 32d, 0)]
    [InlineData(26431662.73648262d, 47577025d, 0)]
    [InlineData(-152436784.334563d, -274386179.802d, 3)]
    [InlineData(0.0d, 32.0d, 1)]
    [InlineData(26431662.73648262d, 47577024.92567d, 5)]
    public void Test_double_extension_generic_with_parameter_from_celsius_and_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = input.From<Celsius>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_and_to_fahrenheit_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.FromFahrenheit()
            .ToFahrenheit();

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
    public void Test_double_extension_generic_from_and_to_fahrenheit_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.From<Fahrenheit>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_double_extensions_from_kelvin_to_fahrenheit_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 33.8d;
        const double input = 274.15d;

        // Act.
        double result = input.FromKelvin()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 33.8d;
        const double input = 274.15d;

        // Act.
        double result = input.From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromKelvin()
                .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_generic_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Kelvin>()
                .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_double_extensions_from_gas_to_fahrenheit_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 428d;
        const double input = 7d;

        // Act.
        double result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_gas_to_fahrenheit_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 428d;
        const double input = 7d;

        // Act.
        double result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000d, -1459.67d)]
    [InlineData(0d, -459.67d)]
    [InlineData(50d, -409.67d)]
    [InlineData(100d, -359.67d)]
    [InlineData(500d, 40.329999999999984d)]
    [InlineData(1000d, 540.3299999999999d)]
    public void Test_double_extension_from_rankine_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -1459.67d)]
    [InlineData(0d, -459.67d)]
    [InlineData(50d, -409.67d)]
    [InlineData(100d, -359.67d)]
    [InlineData(500d, 40.329999999999984d)]
    [InlineData(1000d, 540.3299999999999d)]
    public void Test_double_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -1459.67d, -1)]
    [InlineData(0d, -459.67d, -1)]
    [InlineData(50d, -409.67d, -1)]
    [InlineData(100d, -359.67d, -1)]
    [InlineData(500d, 40.329999999999984d, -1)]
    [InlineData(1000d, 540.3299999999999d, -1)]
    [InlineData(-1000d, -1460d, 0)]
    [InlineData(0d, -460d, 0)]
    [InlineData(50d, -410d, 0)]
    [InlineData(100d, -360d, 0)]
    [InlineData(500d, 40d, 0)]
    [InlineData(1000d, 540d, 0)]
    [InlineData(-1000d, -1459.7d, 1)]
    [InlineData(0d, -459.67d, 2)]
    [InlineData(50d, -409.7d, 1)]
    [InlineData(100d, -359.7d, 1)]
    [InlineData(500d, 40.32999999999998d, 14)]
    [InlineData(1000d, 540.33d, 2)]
    public void Test_double_extension_with_parameter_from_rankine_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -1459.67d, -1)]
    [InlineData(0d, -459.67d, -1)]
    [InlineData(50d, -409.67d, -1)]
    [InlineData(100d, -359.67d, -1)]
    [InlineData(500d, 40.329999999999984d, -1)]
    [InlineData(1000d, 540.3299999999999d, -1)]
    [InlineData(-1000d, -1460d, 0)]
    [InlineData(0d, -460d, 0)]
    [InlineData(50d, -410d, 0)]
    [InlineData(100d, -360d, 0)]
    [InlineData(500d, 40d, 0)]
    [InlineData(1000d, 540d, 0)]
    [InlineData(-1000d, -1459.7d, 1)]
    [InlineData(0d, -459.67d, 2)]
    [InlineData(50d, -409.7d, 1)]
    [InlineData(100d, -359.7d, 1)]
    [InlineData(500d, 40.32999999999998d, 14)]
    [InlineData(1000d, 540.33d, 2)]
    public void Test_double_extension_generic_with_parameter_from_rankine_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine
}
