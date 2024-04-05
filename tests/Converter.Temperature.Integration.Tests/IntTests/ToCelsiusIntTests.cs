namespace Converter.Temperature.Integration.Tests.IntTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Celsius;
using Extensions.To.Rankine;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToCelsiusIntTests
{
    #region From Celsius

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_and_to_celsius_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromCelsius()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_generic_from_and_to_celsius_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.From<Celsius>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(50, 10)]
    [InlineData(int.MinValue, -1193046489)]
    [InlineData(int.MaxValue, 1193046453)]
    public void Test_int_extensions_from_fahrenheit_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(50, 10)]
    [InlineData(int.MinValue, -1193046489)]
    [InlineData(int.MaxValue, 1193046453)]
    public void Test_int_extensions_generic_from_fahrenheit_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_int_extensions_from_kelvin_to_celsius_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 1;
        const int input = 274;

        // Act.
        int result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_kelvin_to_celsius_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 1;
        const int input = 274;

        // Act.
        int result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_int_value(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromKelvin()
                .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_int_value(
        int input)
    {
        // Arrange.
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
    [InlineData(1, 150)]
    [InlineData(2, 165)]
    [InlineData(3, 180)]
    [InlineData(4, 190)]
    [InlineData(5, 202)]
    [InlineData(6, 217)]
    [InlineData(7, 230)]
    [InlineData(8, 240)]
    [InlineData(9, 250)]
    [InlineData(10, 265)]
    public void Test_int_extensions_from_gas_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromGas()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1, 150)]
    [InlineData(2, 165)]
    [InlineData(3, 180)]
    [InlineData(4, 190)]
    [InlineData(5, 202)]
    [InlineData(6, 217)]
    [InlineData(7, 230)]
    [InlineData(8, 240)]
    [InlineData(9, 250)]
    [InlineData(10, 265)]
    public void Test_int_extensions_generic_from_gas_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Gas>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(11)]
    public void Test_int_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        int input)
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
    [InlineData(0)]
    [InlineData(11)]
    public void Test_int_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        int input)
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
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_and_to_rankine_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromRankine()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_generic_from_and_to_rankine_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.From<Rankine>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(0, -14)]
    [InlineData(50, 81)]
    [InlineData(100, 176)]
    [InlineData(500, 938)]
    [InlineData(1000, 1890)]
    public void Test_int_extension_from_rømer_and_to_celsius_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, -14)]
    [InlineData(50, 81)]
    [InlineData(100, 176)]
    [InlineData(500, 938)]
    [InlineData(1000, 1890)]
    public void Test_int_extension_generic_from_rømer_and_to_celsius_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rømer
}
