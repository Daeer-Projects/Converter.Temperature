namespace Converter.Temperature.Integration.Tests.DoubleTests;

using Extensions.From;
using Extensions.To;
using Extensions.To.Delisle;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

/// <summary>
///     The to delisle double tests.
/// </summary>
public sealed class ToDelisleDoubleTests
{
    #region From Celsius

    [Theory]
    [InlineData(0d, 150d)]
    [InlineData(100d, 0d)]
    [InlineData(-100d, 300d)]
    public void Test_double_extension_from_celsius_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(32d, 150d)]
    [InlineData(212d, 0d)]
    public void Test_double_extension_from_fahrenheit_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(273.15d, 150d)]
    [InlineData(373.15d, 0d)]
    public void Test_double_extension_from_kelvin_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromKelvin()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData(1d, -60d)]
    [InlineData(6d, -150d)]
    public void Test_double_extension_from_gas_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(491.67d, 150d)]
    [InlineData(671.67d, 0d)]
    public void Test_double_extension_from_rankine_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRankine()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.00000000001d);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(7.5d, 150d)]
    [InlineData(60d, 0d)]
    public void Test_double_extension_from_rømer_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(0d)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_delisle_to_delisle_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Delisle
}

