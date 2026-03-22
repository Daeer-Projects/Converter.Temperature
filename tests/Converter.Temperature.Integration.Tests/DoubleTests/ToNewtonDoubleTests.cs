namespace Converter.Temperature.Integration.Tests.DoubleTests;

using Extensions.From;
using Extensions.To;
using Extensions.To.Newton;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

/// <summary>
///     The to newton double tests.
/// </summary>
public sealed class ToNewtonDoubleTests
{
    #region From Celsius

    [Theory]
    [InlineData(100.0, 33.0)]
    [InlineData(0.0, 0.0)]
    [InlineData(-33.0, -10.89)]
    public void Test_double_extension_from_celsius_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(212.0, 33.0)]
    [InlineData(32.0, 0.0)]
    public void Test_double_extension_from_fahrenheit_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromFahrenheit()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(373.15, 33.0)]
    [InlineData(273.15, 0.0)]
    public void Test_double_extension_from_kelvin_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromKelvin()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData(671.67, 33.0)]
    [InlineData(491.67, 0.0)]
    public void Test_double_extension_from_rankine_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRankine()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(60.0, 33.0)]
    [InlineData(7.5, 0.0)]
    public void Test_double_extension_from_rømer_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRømer()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(0.0, 33.0)]
    [InlineData(150.0, 0.0)]
    public void Test_double_extension_from_delisle_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromDelisle()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData(33.0, 33.0)]
    [InlineData(0.0, 0.0)]
    public void Test_double_extension_from_newton_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Newton

    #region From Réaumur

    [Theory]
    [InlineData(80.0, 33.0)]
    [InlineData(0.0, 0.0)]
    public void Test_double_extension_from_réaumur_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRéaumur()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion From Réaumur

    #region Generic

    [Fact]
    public void Test_double_extension_generic_from_celsius_to_newton_returns_correct_double_value()
    {
        // Arrange.
        const double input = 100.0;
        const double expected = 33.0;

        // Act.
        double result = input.FromCelsius()
            .To<Newton>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }

    #endregion Generic
}
