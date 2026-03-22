using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests;

/// <summary>
/// The to réaumur int tests.
/// </summary>
public sealed class ToRéaumurIntTests
{
    #region From Celsius

    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 80)]
    public void Test_int_extension_from_celsius_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromCelsius().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 80)]
    public void Test_int_extension_from_fahrenheit_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromFahrenheit().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(273, 0)]
    [InlineData(373, 80)]
    public void Test_int_extension_from_kelvin_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromKelvin().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData(492, 0)]
    [InlineData(672, 80)]
    public void Test_int_extension_from_rankine_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRankine().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rankine

    #region From Delisle

    [Theory]
    [InlineData(0, 80)]
    [InlineData(150, 0)]
    public void Test_int_extension_from_delisle_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromDelisle().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData(0, 0)]
    [InlineData(33, 80)]
    public void Test_int_extension_from_newton_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromNewton().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Newton

    #region From Rømer

    [Theory]
    [InlineData(7, -1)]
    [InlineData(60, 80)]
    public void Test_int_extension_from_rømer_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRømer().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rømer

    #region From Réaumur

    [Theory]
    [InlineData(0, 0)]
    [InlineData(80, 80)]
    public void Test_int_extension_from_réaumur_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRéaumur().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Réaumur

    #region Generic

    [Fact]
    public void Test_int_extension_generic_from_celsius_to_réaumur_returns_correct_int_value()
    {
        // Arrange.
        const int input = 100;
        const int expected = 80;

        // Act.
        int result = input.FromCelsius().To<Réaumur>();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion Generic
}
