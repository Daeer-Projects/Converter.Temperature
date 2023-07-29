namespace Converter.Temperature.Integration.Tests.LongTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Celsius;
using Extensions.To.Rankine;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToCelsiusLongTests
{
    #region From Celsius

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_and_to_celsius_returns_correct_long_value(long value)
    {
        // Arrange.
        // Act.
        long result = value.FromCelsius()
            .ToCelsius();

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
    public void Test_long_extension_generic_from_and_to_celsius_returns_correct_long_value(long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Celsius>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(50L, 10L)]
    [InlineData(long.MinValue, -5124095576030431232L)]
    [InlineData(long.MaxValue, 5124095576030431232L)]
    public void Test_long_extensions_from_fahrenheit_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(50L, 10L)]
    [InlineData(long.MinValue, -5124095576030431232L)]
    [InlineData(long.MaxValue, 5124095576030431232L)]
    public void Test_long_extensions_generic_from_fahrenheit_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_long_extensions_from_kelvin_to_celsius_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 1L;
        const long input = 274L;

        // Act.
        long result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_kelvin_to_celsius_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 1L;
        const long input = 274L;

        // Act.
        long result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_long_value()
    {
        // Arrange.
        const long input = long.MinValue;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromKelvin()
                .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_long_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_long_value()
    {
        // Arrange.
        const long input = long.MinValue;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Kelvin>()
                .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData(1L, 150L)]
    [InlineData(2L, 165L)]
    [InlineData(3L, 180L)]
    [InlineData(4L, 190L)]
    [InlineData(5L, 202L)]
    [InlineData(6L, 217L)]
    [InlineData(7L, 230L)]
    [InlineData(8L, 240L)]
    [InlineData(9L, 250L)]
    [InlineData(10L, 265L)]
    public void Test_long_extensions_from_gas_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromGas()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1L, 150L)]
    [InlineData(2L, 165L)]
    [InlineData(3L, 180L)]
    [InlineData(4L, 190L)]
    [InlineData(5L, 202L)]
    [InlineData(6L, 217L)]
    [InlineData(7L, 230L)]
    [InlineData(8L, 240L)]
    [InlineData(9L, 250L)]
    [InlineData(10L, 265L)]
    public void Test_long_extensions_generic_from_gas_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Gas>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void Test_long_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        long input)
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
    [InlineData(0L)]
    [InlineData(11L)]
    public void Test_long_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        long input)
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
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_and_to_rankine_returns_correct_long_value(long value)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToRankine();

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
    public void Test_long_extension_generic_from_and_to_rankine_returns_correct_long_value(long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Rankine
}