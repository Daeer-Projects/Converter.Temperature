namespace Converter.Temperature.Integration.Tests.FloatTests;

using Extensions.From;
using Extensions.To;
using Extensions.To.Delisle;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToDelisleFloatTests
{
    #region From Celsius

    [Theory]
    [InlineData(0f, 150f)]
    [InlineData(100f, 0f)]
    [InlineData(-100f, 300f)]
    public void Test_float_extension_from_celsius_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(32f, 150f)]
    [InlineData(212f, 0f)]
    public void Test_float_extensions_from_fahrenheit_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(273.15f, 150f)]
    [InlineData(373.15f, 0f)]
    public void Test_float_extensions_from_kelvin_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromKelvin()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData(1f, -60f)]
    [InlineData(6f, -150f)]
    public void Test_float_extensions_from_gas_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(491.67f, 150f)]
    [InlineData(671.67f, 0f)]
    public void Test_float_extensions_from_rankine_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRankine()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.001f);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(7.5f, 150f)]
    [InlineData(60f, 0f)]
    public void Test_float_extensions_from_rømer_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    #endregion From Rømer

    #region From Delisle

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(0f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_delisle_to_delisle_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Delisle
}
