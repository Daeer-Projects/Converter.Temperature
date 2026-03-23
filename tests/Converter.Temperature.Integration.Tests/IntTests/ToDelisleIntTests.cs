using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests;

/// <summary>
///     The to delisle int tests.
/// </summary>
public sealed class ToDelisleIntTests
{
    #region From Celsius

    [Theory]
    [InlineData(0, 150)]
    [InlineData(100, 0)]
    [InlineData(-100, 300)]
    public void Test_int_extension_from_celsius_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, 150)]
    [InlineData(100, 0)]
    public void Test_int_extension_generic_from_celsius_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Celsius>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(32, 150)]
    [InlineData(212, 0)]
    public void Test_int_extension_from_fahrenheit_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(273, 150)]
    [InlineData(373, 0)]
    public void Test_int_extension_from_kelvin_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromKelvin()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData(1, -75)]
    [InlineData(6, -176)]
    [InlineData(10, -248)]
    public void Test_int_extension_from_gas_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(492, 150)]
    [InlineData(672, 0)]
    public void Test_int_extension_from_rankine_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRankine()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(8, 150)]
    [InlineData(60, 0)]
    public void Test_int_extension_from_rømer_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(0)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_delisle_to_delisle_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Delisle
}
