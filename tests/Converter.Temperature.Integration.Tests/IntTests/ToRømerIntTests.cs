using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests;

/// <summary>
/// The to rømer int tests.
/// </summary>
public sealed class ToRømerIntTests
{
    #region From Celsius

    [Fact]
    public void Test_int_extension_from_celsius_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 200;

        // Act.
        int result = input.FromCelsius()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_celsius_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 200;

        // Act.
        int result = input.From<Celsius>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_int_extension_from_fahrenheit_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_fahrenheit_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(-1000, -661)]
    [InlineData(0, -136)]
    [InlineData(50, -110)]
    [InlineData(1000, 389)]
    public void Test_int_extension_from_kelvin_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -661)]
    [InlineData(0, -136)]
    [InlineData(50, -110)]
    [InlineData(1000, 389)]
    public void Test_int_extension_generic_from_kelvin_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_int_extension_from_gas_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 121;
        const int input = 6;

        // Act.
        int result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_gas_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 121;
        const int input = 6;

        // Act.
        int result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000, -428)]
    [InlineData(0, -136)]
    [InlineData(50, -121)]
    [InlineData(100, -107)]
    [InlineData(500, 10)]
    [InlineData(1000, 156)]
    public void Test_int_extension_from_rankine_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -428)]
    [InlineData(0, -136)]
    [InlineData(50, -121)]
    [InlineData(100, -107)]
    [InlineData(500, 10)]
    [InlineData(1000, 156)]
    public void Test_int_extension_generic_from_rankine_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_and_to_rømer_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToRømer();

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
    public void Test_int_extension_generic_from_and_to_rømer_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Rømer
}
