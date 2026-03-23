using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests;

/// <summary>
///     The to delisle string tests.
/// </summary>
public sealed class ToDelisleStringTests
{
    #region From Celsius

    [Theory]
    [InlineData("0", "150")]
    [InlineData("100", "0")]
    [InlineData("-100", "300")]
    public void Test_string_extension_from_celsius_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData("32", "150")]
    [InlineData("212", "0")]
    public void Test_string_extension_from_fahrenheit_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData("273.15", "150")]
    [InlineData("373.15", "0")]
    public void Test_string_extension_from_kelvin_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromKelvin()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData("1", "-60")]
    [InlineData("6", "-150")]
    public void Test_string_extension_from_gas_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData("491.67", "150")]
    [InlineData("671.67", "0")]
    public void Test_string_extension_from_rankine_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRankine()
            .ToDelisle();

        // Assert.
        double resultDouble = double.Parse(result);
        double expectedDouble = double.Parse(expected);
        resultDouble.Should()
            .BeApproximately(expectedDouble, 0.00000000001d);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData("7.5", "150")]
    [InlineData("60", "0")]
    public void Test_string_extension_from_rømer_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData("0")]
    [InlineData("150")]
    public void Test_string_extension_from_delisle_to_delisle_returns_correct_string_value(
        string value)
    {
        // Arrange.
        // Act.
        string result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Delisle
}
