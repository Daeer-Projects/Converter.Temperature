namespace Converter.Temperature.Integration.Tests.FloatTests;

using Extensions.From;
using Extensions.To;
using Extensions.To.Kelvin;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToKelvinFloatTests
{
    #region From Celsius

    [Fact]
    public void Test_float_extensions_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 200f;

        // Act.
        float result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 200f;

        // Act.
        float result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 392f;

        // Act.
        float result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 392f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(-345.65f)]
    [InlineData(0.0f)]
    [InlineData(7564.2334f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_and_to_kelvin_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromKelvin()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(-345.65f)]
    [InlineData(0.0f)]
    [InlineData(7564.2334f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_generic_from_and_to_kelvin_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.From<Kelvin>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_float_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 6f;

        // Act.
        float result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 6f;

        // Act.
        float result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000d, -555.5555555555555f)]
    [InlineData(0d, 0f)]
    [InlineData(50d, 27.77777777777778f)]
    [InlineData(100d, 55.55555555555556f)]
    [InlineData(500d, 277.77777777777777f)]
    [InlineData(1000d, 555.5555555555555f)]
    public void Test_double_extension_from_rankine_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555f)]
    [InlineData(0d, 0f)]
    [InlineData(50d, 27.77777777777778f)]
    [InlineData(100d, 55.55555555555556f)]
    [InlineData(500d, 277.77777777777777f)]
    [InlineData(1000d, 555.5555555555555f)]
    public void Test_double_extension_generic_from_rankine_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(-1000f, -1645.8976190476192f)]
    [InlineData(0f, 258.8642857142857f)]
    [InlineData(50f, 354.10236f)]
    [InlineData(100f, 449.34045f)]
    [InlineData(500f, 1211.2452380952382f)]
    [InlineData(1000f, 2163.6261904761905f)]
    public void Test_float_extension_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -1645.8976190476192f)]
    [InlineData(0f, 258.8642857142857f)]
    [InlineData(50f, 354.10236f)]
    [InlineData(100f, 449.34045f)]
    [InlineData(500f, 1211.2452380952382f)]
    [InlineData(1000f, 2163.6261904761905f)]
    public void Test_float_extension_generic_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -1645.8976190476192f, -1)]
    [InlineData(0f, 258.8642857142857f, -1)]
    [InlineData(50f, 354.10236f, -1)]
    [InlineData(100f, 449.34045f, -1)]
    [InlineData(500f, 1211.2452380952382f, -1)]
    [InlineData(1000f, 2163.6261904761905f, -1)]
    [InlineData(-1000f, -1646f, 0)]
    [InlineData(0f, 259f, 0)]
    [InlineData(50f, 354f, 0)]
    [InlineData(100f, 449f, 0)]
    [InlineData(500f, 1211f, 0)]
    [InlineData(1000f, 2164f, 0)]
    [InlineData(-1000f, -1645.9f, 1)]
    [InlineData(0f, 258.8642857142857f, 13)]
    [InlineData(50f, 354.1024f, 4)]
    [InlineData(100f, 449.3f, 1)]
    [InlineData(500f, 1211.2452381f, 7)]
    [InlineData(1000f, 2163.6261904761905f, 14)]
    public void Test_float_extension_with_parameter_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -1645.8976190476192f, -1)]
    [InlineData(0f, 258.8642857142857f, -1)]
    [InlineData(50f, 354.10236f, -1)]
    [InlineData(100f, 449.34045f, -1)]
    [InlineData(500f, 1211.2452380952382f, -1)]
    [InlineData(1000f, 2163.6261904761905f, -1)]
    [InlineData(-1000f, -1646f, 0)]
    [InlineData(0f, 259f, 0)]
    [InlineData(50f, 354f, 0)]
    [InlineData(100f, 449f, 0)]
    [InlineData(500f, 1211f, 0)]
    [InlineData(1000f, 2164f, 0)]
    [InlineData(-1000f, -1645.9f, 1)]
    [InlineData(0f, 258.8642857142857f, 13)]
    [InlineData(50f, 354.1024f, 4)]
    [InlineData(100f, 449.3f, 1)]
    [InlineData(500f, 1211.2452381f, 7)]
    [InlineData(1000f, 2163.6261904761905f, 14)]
    public void Test_float_extension_generic_with_parameter_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rømer
}
