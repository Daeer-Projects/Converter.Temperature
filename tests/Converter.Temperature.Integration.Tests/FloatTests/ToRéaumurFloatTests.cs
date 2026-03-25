using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests;

/// <summary>
///     The to réaumur float tests.
/// </summary>
public sealed class ToRéaumurFloatTests
{
    #region From Celsius

    [Theory]
    [InlineData(0f, 0f)]
    [InlineData(100f, 80f)]
    public void Test_float_extension_from_celsius_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromCelsius().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(32f, 0f)]
    [InlineData(212f, 80f)]
    public void Test_float_extension_from_fahrenheit_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromFahrenheit().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(273.15f, 0f)]
    [InlineData(373.15f, 80f)]
    public void Test_float_extension_from_kelvin_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromKelvin().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData(491.67f, 0f)]
    [InlineData(671.67f, 80f)]
    public void Test_float_extension_from_rankine_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRankine().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Rankine

    #region From Delisle

    [Theory]
    [InlineData(0f, 80f)]
    [InlineData(150f, 0f)]
    public void Test_float_extension_from_delisle_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromDelisle().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData(0f, 0f)]
    [InlineData(33f, 80f)]
    public void Test_float_extension_from_newton_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromNewton().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Newton

    #region From Rømer

    [Theory]
    [InlineData(7.5f, 0f)]
    [InlineData(60f, 80f)]
    public void Test_float_extension_from_rømer_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRømer().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Rømer

    #region From Réaumur

    [Theory]
    [InlineData(0f, 0f)]
    [InlineData(80f, 80f)]
    public void Test_float_extension_from_réaumur_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRéaumur().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Réaumur

    #region Generic

    [Fact]
    public void Test_float_extension_generic_from_celsius_to_réaumur_returns_correct_float_value()
    {
        // Arrange.
        const float input = 100f;
        const float expected = 80f;

        // Act.
        float result = input.FromCelsius().To<Réaumur>();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion Generic
}
