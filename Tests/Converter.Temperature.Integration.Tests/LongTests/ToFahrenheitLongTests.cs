namespace Converter.Temperature.Integration.Tests.LongTests;

using System;
using Extensions.From;
using Extensions.To;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToFahrenheitLongTests
{
    #region From Celsius

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        long input)
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
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_generic_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        long input)
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
    [InlineData(-152436784L, -274386179L)]
    [InlineData(0L, 32L)]
    [InlineData(26431662L, 47577024L)]
    public void Test_long_extension_from_celsius_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromCelsius()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-152436784L, -274386179L)]
    [InlineData(0L, 32L)]
    [InlineData(26431662L, 47577024L)]
    public void Test_long_extension_generic_from_celsius_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Celsius>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extensions_from_and_to_fahrenheit_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromFahrenheit()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extensions_generic_from_and_to_fahrenheit_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Fahrenheit>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_long_extensions_from_kelvin_to_fahrenheit_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 34L;
        const long input = 274L;

        // Act.
        long result = input.FromKelvin()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 34L;
        const long input = 274L;

        // Act.
        long result = input.From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_long_value(
        long input)
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
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_generic_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_long_value(
        long input)
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

    [Theory]
    [InlineData(1L, 302L)]
    [InlineData(2L, 329L)]
    [InlineData(3L, 356L)]
    [InlineData(4L, 374L)]
    [InlineData(5L, 396L)]
    [InlineData(6L, 423L)]
    [InlineData(7L, 446L)]
    [InlineData(8L, 464L)]
    [InlineData(9L, 482L)]
    [InlineData(10L, 509L)]
    public void Test_long_extensions_from_gas_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1L, 302L)]
    [InlineData(2L, 329L)]
    [InlineData(3L, 356L)]
    [InlineData(4L, 374L)]
    [InlineData(5L, 396L)]
    [InlineData(6L, 423L)]
    [InlineData(7L, 446L)]
    [InlineData(8L, 464L)]
    [InlineData(9L, 482L)]
    [InlineData(10L, 509L)]
    public void Test_long_extensions_generic_from_gas_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void Test_long_extensions_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromGas()
                .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void
        Test_long_extensions_generic_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Gas>()
                .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000L, -1460L)]
    [InlineData(0L, -460L)]
    [InlineData(50L, -410L)]
    [InlineData(100L, -360L)]
    [InlineData(500L, 40L)]
    [InlineData(1000L, 540L)]
    public void Test_long_extension_from_rankine_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -1460L)]
    [InlineData(0L, -460L)]
    [InlineData(50L, -410L)]
    [InlineData(100L, -360L)]
    [InlineData(500L, 40L)]
    [InlineData(1000L, 540L)]
    public void Test_long_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine
}
