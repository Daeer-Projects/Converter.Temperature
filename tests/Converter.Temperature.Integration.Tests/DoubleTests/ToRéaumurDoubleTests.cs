using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests;

/// <summary>
///     The to réaumur double tests.
/// </summary>
public sealed class ToRéaumurDoubleTests
{
    #region From Celsius

    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 80)]
    public void Test_double_extension_from_celsius_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromCelsius()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 80)]
    public void Test_double_extension_from_fahrenheit_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromFahrenheit()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(273.15, 0)]
    [InlineData(373.15, 80)]
    public void Test_double_extension_from_kelvin_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromKelvin()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData(491.67, 0)]
    [InlineData(671.67, 80)]
    public void Test_double_extension_from_rankine_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromRankine()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Rankine

    #region From Delisle

    [Theory]
    [InlineData(0, 80)]
    [InlineData(150, 0)]
    public void Test_double_extension_from_delisle_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromDelisle()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData(0, 0)]
    [InlineData(33, 80)]
    public void Test_double_extension_from_newton_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromNewton()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Newton

    #region From Rømer

    [Theory]
    [InlineData(7.5, 0)]
    [InlineData(60, 80)]
    public void Test_double_extension_from_rømer_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromRømer()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Rømer

    #region From Réaumur

    [Theory]
    [InlineData(0, 0)]
    [InlineData(80, 80)]
    public void Test_double_extension_from_réaumur_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromRéaumur()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion From Réaumur

    #region Generic

    [Fact]
    public void Test_double_extension_generic_from_celsius_to_réaumur_returns_correct_double_value()
    {
        // Arrange.
        const double input = 100;
        const double expected = 80;

        // Act.
        double result = input.FromCelsius()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    #endregion Generic
}
