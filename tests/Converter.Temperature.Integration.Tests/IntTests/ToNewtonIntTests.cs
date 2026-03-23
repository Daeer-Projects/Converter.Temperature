using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests;

/// <summary>
/// The to newton int tests.
/// </summary>
public sealed class ToNewtonIntTests
{
    #region From Celsius

    [Theory]
    [InlineData(100, 33)]
    [InlineData(0, 0)]
    [InlineData(-33, -11)]
    public void Test_int_extension_from_celsius_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(212, 33)]
    [InlineData(32, 0)]
    [InlineData(0, -6)]
    public void Test_int_extension_from_fahrenheit_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromFahrenheit().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(373, 33)]
    [InlineData(273, 0)]
    public void Test_int_extension_from_kelvin_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromKelvin().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData(672, 33)]
    [InlineData(492, 0)]
    public void Test_int_extension_from_rankine_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRankine().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(60, 33)]
    [InlineData(7, 0)]
    public void Test_int_extension_from_rømer_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRømer().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(0, 33)]
    [InlineData(150, 0)]
    public void Test_int_extension_from_delisle_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromDelisle().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData(33, 33)]
    [InlineData(0, 0)]
    public void Test_int_extension_from_newton_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromNewton().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Newton

    #region From Réaumur

    [Theory]
    [InlineData(80, 33)]
    [InlineData(0, 0)]
    public void Test_int_extension_from_réaumur_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRéaumur().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Réaumur
}
