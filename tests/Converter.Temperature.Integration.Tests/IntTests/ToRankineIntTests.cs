namespace Converter.Temperature.Integration.Tests.IntTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Rankine;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToRankineIntTests
{
    #region From Celsius

    [Fact]
    public void Test_int_extensions_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        const int input = 200;

        // Act.
        int result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        const int input = 200;

        // Act.
        int result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Celsius>()
                .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(-1000, -1800)]
    [InlineData(0, 0)]
    [InlineData(50, 90)]
    [InlineData(1000, 1800)]
    public void Test_int_extension_from_kelvin_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -1800)]
    [InlineData(0, 0)]
    [InlineData(50, 90)]
    [InlineData(1000, 1800)]
    public void Test_int_extension_generic_from_kelvin_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_int_extension_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 882;
        const int input = 6;

        // Act.
        int result = input.FromGas()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 882;
        const int input = 6;

        // Act.
        int result = input.From<Gas>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
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
    [InlineData(-1000, -2963)]
    [InlineData(0, 466)]
    [InlineData(50, 637)]
    [InlineData(100, 809)]
    [InlineData(500, 2180)]
    [InlineData(1000, 3895)]
    public void Test_int_extension_from_rømer_and_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -2963)]
    [InlineData(0, 466)]
    [InlineData(50, 637)]
    [InlineData(100, 809)]
    [InlineData(500, 2180)]
    [InlineData(1000, 3895)]
    public void Test_int_extension_generic_from_rømer_and_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rømer
}
