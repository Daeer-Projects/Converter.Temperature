using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests;

/// <summary>
/// The to newton float tests.
/// </summary>
public sealed class ToNewtonFloatTests
{
    #region From Celsius

    [Theory]
    [InlineData(100.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_float_extension_from_celsius_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(212.0f, 33.0f)]
    [InlineData(32.0f, 0.0f)]
    public void Test_float_extension_from_fahrenheit_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromFahrenheit().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(373.15f, 33.0f)]
    [InlineData(273.15f, 0.0f)]
    public void Test_float_extension_from_kelvin_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromKelvin().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData(671.67f, 33.0f)]
    [InlineData(491.67f, 0.0f)]
    public void Test_float_extension_from_rankine_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRankine().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(60.0f, 33.0f)]
    [InlineData(7.5f, 0.0f)]
    public void Test_float_extension_from_rømer_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRømer().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(0.0f, 33.0f)]
    [InlineData(150.0f, 0.0f)]
    public void Test_float_extension_from_delisle_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromDelisle().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData(33.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_float_extension_from_newton_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromNewton().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }

    #endregion From Newton

    #region From Réaumur

    [Theory]
    [InlineData(80.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_float_extension_from_réaumur_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRéaumur().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    #endregion From Réaumur
}
