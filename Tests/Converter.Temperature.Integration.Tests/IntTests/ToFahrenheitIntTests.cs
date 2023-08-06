namespace Converter.Temperature.Integration.Tests.IntTests;

using System;
using Extensions.From;
using Extensions.To;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToFahrenheitIntTests
{
    #region From Celsius

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        int input)
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
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_generic_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        int input)
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
    [InlineData(-152436784, -274386179)]
    [InlineData(0, 32)]
    [InlineData(26431662, 47577024)]
    public void Test_int_extension_from_celsius_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromCelsius()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-152436784, -274386179)]
    [InlineData(0, 32)]
    [InlineData(26431662, 47577024)]
    public void Test_int_extension_generic_from_celsius_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Celsius>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_from_and_to_fahrenheit_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromFahrenheit()
            .ToFahrenheit();

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
    public void Test_int_extensions_generic_from_and_to_fahrenheit_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.From<Fahrenheit>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_int_extensions_from_kelvin_to_fahrenheit_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 34;
        const int input = 274;

        // Act.
        int result = input.FromKelvin()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 34;
        const int input = 274;

        // Act.
        int result = input.From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_int_value(
        int input)
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
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_generic_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_int_value(
        int input)
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
    [InlineData(1, 302)]
    [InlineData(2, 329)]
    [InlineData(3, 356)]
    [InlineData(4, 374)]
    [InlineData(5, 396)]
    [InlineData(6, 423)]
    [InlineData(7, 446)]
    [InlineData(8, 464)]
    [InlineData(9, 482)]
    [InlineData(10, 509)]
    public void Test_int_extensions_from_gas_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1, 302)]
    [InlineData(2, 329)]
    [InlineData(3, 356)]
    [InlineData(4, 374)]
    [InlineData(5, 396)]
    [InlineData(6, 423)]
    [InlineData(7, 446)]
    [InlineData(8, 464)]
    [InlineData(9, 482)]
    [InlineData(10, 509)]
    public void Test_int_extensions_generic_from_gas_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(11)]
    public void Test_int_extensions_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
        int input)
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
    [InlineData(0)]
    [InlineData(11)]
    public void Test_int_extensions_generic_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
        int input)
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
    [InlineData(-1000, -1460)]
    [InlineData(0, -460)]
    [InlineData(50, -410)]
    [InlineData(100, -360)]
    [InlineData(500, 40)]
    [InlineData(1000, 540)]
    public void Test_int_extension_from_rankine_and_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -1460)]
    [InlineData(0, -460)]
    [InlineData(50, -410)]
    [InlineData(100, -360)]
    [InlineData(500, 40)]
    [InlineData(1000, 540)]
    public void Test_int_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine
}
