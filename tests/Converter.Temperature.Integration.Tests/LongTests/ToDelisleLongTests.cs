using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests;

/// <summary>
///     The to delisle long tests.
/// </summary>
public sealed class ToDelisleLongTests
{
    #region From Celsius

    [Theory]
    [InlineData(0L, 150L)]
    [InlineData(100L, 0L)]
    [InlineData(-100L, 300L)]
    public void Test_long_extension_from_celsius_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(32L, 150L)]
    [InlineData(212L, 0L)]
    public void Test_long_extension_from_fahrenheit_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(273L, 150L)]
    [InlineData(373L, 0L)]
    public void Test_long_extension_from_kelvin_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromKelvin()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData(1L, -75L)]
    [InlineData(6L, -176L)]
    public void Test_long_extension_from_gas_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(492L, 150L)]
    [InlineData(672L, 0L)]
    public void Test_long_extension_from_rankine_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRankine()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(8L, 150L)]
    [InlineData(60L, 0L)]
    public void Test_long_extension_from_rømer_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(0L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_delisle_to_delisle_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Delisle
}
