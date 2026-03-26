using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests;

/// <summary>
///     The to newton string tests.
/// </summary>
public sealed class ToNewtonStringTests
{
    #region From Celsius

    [Theory]
    [InlineData("100", "33")]
    [InlineData("0", "0")]
    public void Test_string_extension_from_celsius_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData("212", "33")]
    [InlineData("32", "0")]
    public void Test_string_extension_from_fahrenheit_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromFahrenheit().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData("373.15", "33")]
    [InlineData("273.15", "0")]
    public void Test_string_extension_from_kelvin_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromKelvin().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Kelvin

    #region From Rankine

    [Theory]
    [InlineData("671.67", "33")]
    [InlineData("491.67", "0")]
    public void Test_string_extension_from_rankine_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromRankine().ToNewton(0);

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData("60", "33")]
    [InlineData("7.5", "0")]
    public void Test_string_extension_from_rømer_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromRømer().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData("0", "33")]
    [InlineData("150", "0")]
    public void Test_string_extension_from_delisle_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromDelisle().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Delisle

    #region From Newton

    [Theory]
    [InlineData("33", "33")]
    [InlineData("0", "0")]
    public void Test_string_extension_from_newton_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromNewton().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Newton

    #region From Réaumur

    [Theory]
    [InlineData("80", "33")]
    [InlineData("0", "0")]
    public void Test_string_extension_from_réaumur_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromRéaumur().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }

    #endregion From Réaumur
}
