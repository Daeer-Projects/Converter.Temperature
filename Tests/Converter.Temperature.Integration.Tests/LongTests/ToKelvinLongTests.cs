namespace Converter.Temperature.Integration.Tests.LongTests;

using System;
using Extensions.From;
using Extensions.To;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public class ToKelvinLongTests
{
    #region From Celsius

    [Fact]
    public void Test_long_extensions_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 200L;

        // Act.
        long result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 200L;

        // Act.
        long result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        const long input = long.MaxValue;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_long_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        const long input = long.MaxValue;

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
    public void Test_long_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 392L;

        // Act.
        long result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 392L;

        // Act.
        long result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_and_to_kelvin_returns_correct_long_value(long value)
    {
        // Arrange.
        // Act.
        long result = value.FromKelvin()
            .ToKelvin();

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
    public void Test_long_extension_generic_from_and_to_kelvin_returns_correct_long_value(long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Kelvin>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_long_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 490L;
        const long input = 6L;

        // Act.
        long result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 490L;
        const long input = 6L;

        // Act.
        long result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000L, -555L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 27L)]
    [InlineData(100L, 55L)]
    [InlineData(500L, 277L)]
    [InlineData(1000L, 555L)]
    public void Test_long_extension_from_rankine_and_to_kelvin_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -555L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 27L)]
    [InlineData(100L, 55L)]
    [InlineData(500L, 277L)]
    [InlineData(1000L, 555L)]
    public void Test_long_extension_generic_from_rankine_and_to_kelvin_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine
}