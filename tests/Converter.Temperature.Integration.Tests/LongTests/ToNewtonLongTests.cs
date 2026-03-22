using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests;

/// <summary>
/// The to newton long tests.
/// </summary>
public sealed class ToNewtonLongTests
{
    #region From Celsius

    [Theory]
    [InlineData(100L, 33L)]
    [InlineData(0L, 0L)]
    [InlineData(-33L, -11L)]
    public void Test_long_extension_from_celsius_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(212L, 33L)]
    [InlineData(32L, 0L)]
    public void Test_long_extension_from_fahrenheit_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromFahrenheit().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(373L, 33L)]
    [InlineData(273L, 0L)]
    public void Test_long_extension_from_kelvin_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromKelvin().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData(672L, 33L)]
    [InlineData(492L, 0L)]
    public void Test_long_extension_from_rankine_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromRankine().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(60L, 33L)]
    [InlineData(7L, 0L)]
    public void Test_long_extension_from_rømer_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromRømer().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(0L, 33L)]
    [InlineData(150L, 0L)]
    public void Test_long_extension_from_delisle_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromDelisle().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData(33L, 33L)]
    [InlineData(0L, 0L)]
    public void Test_long_extension_from_newton_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromNewton().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Newton

    #region From Réaumur

    [Theory]
    [InlineData(80L, 33L)]
    [InlineData(0L, 0L)]
    public void Test_long_extension_from_réaumur_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromRéaumur().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Réaumur
}
