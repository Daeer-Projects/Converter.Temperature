namespace Converter.Temperature.Integration.Tests.FloatTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Fahrenheit;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToFahrenheitFloatTests
{
    #region From Celsius

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void
        Test_float_extension_generic_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
            float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-152436784.334563f, -274386179.8022134f)]
    [InlineData(0.0f, 32.0f)]
    [InlineData(26431662.73648262f, 47577024.925668716f)]
    public void Test_float_extension_from_celsius_and_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromCelsius()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-152436784.334563f, -274386179.8022134f)]
    [InlineData(0.0f, 32.0f)]
    [InlineData(26431662.73648262f, 47577024.925668716f)]
    public void Test_float_extension_generic_from_celsius_and_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Celsius>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(-345.65f)]
    [InlineData(0.0f)]
    [InlineData(7564.2334f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_and_to_fahrenheit_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromFahrenheit()
            .ToFahrenheit();

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
    public void Test_float_extension_generic_from_and_to_fahrenheit_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.From<Fahrenheit>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_float_extensions_from_kelvin_to_fahrenheit_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 33.80198f;
        const float input = 274.15110239825f;

        // Act.
        float result = input.FromKelvin()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 33.80198f;
        const float input = 274.15110239825f;

        // Act.
        float result = input.From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(34.193474f, -1)]
    [InlineData(34.2f, 1)]
    [InlineData(34.19347f, 5)]
    public void Test_float_extensions_from_kelvin_with_parameter_to_fahrenheit_returns_correct_float_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        const float input = 274.36857625f;

        // Act.
        float result = input.FromKelvin()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(34.193474f, -1)]
    [InlineData(34.2f, 1)]
    [InlineData(34.19347f, 5)]
    public void Test_float_extensions_generic_from_kelvin_with_parameter_to_fahrenheit_returns_correct_float_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        const float input = 274.36857625f;

        // Act.
        float result = input.From<Kelvin>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin()
            .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_generic_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Kelvin>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_float_extensions_from_gas_to_fahrenheit_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 428f;
        const float input = 7f;

        // Act.
        float result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_float_extensions_generic_from_gas_to_fahrenheit_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 428f;
        const float input = 7f;

        // Act.
        float result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000d, -1459.67f)]
    [InlineData(0d, -459.67f)]
    [InlineData(50d, -409.67f)]
    [InlineData(100d, -359.67f)]
    [InlineData(500d, 40.329987f)]
    [InlineData(1000d, 540.32996f)]
    public void Test_float_extension_from_rankine_and_to_fahrenheit_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -1459.67f)]
    [InlineData(0d, -459.67f)]
    [InlineData(50d, -409.67f)]
    [InlineData(100d, -359.67f)]
    [InlineData(500d, 40.329987f)]
    [InlineData(1000d, 540.32996f)]
    public void Test_float_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(-1000f, -3422.285714285714f)]
    [InlineData(0f, 6.285715f)]
    [InlineData(50f, 177.71428571428572f)]
    [InlineData(100f, 349.14285714285717f)]
    [InlineData(500f, 1720.5714285714287f)]
    [InlineData(1000f, 3434.8571428571427f)]
    public void Test_double_extension_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -3422.285714285714f)]
    [InlineData(0f, 6.285715f)]
    [InlineData(50f, 177.71428571428572f)]
    [InlineData(100f, 349.14285714285717f)]
    [InlineData(500f, 1720.5714285714287f)]
    [InlineData(1000f, 3434.8571428571427f)]
    public void Test_double_extension_generic_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -3422.285714285714f, -1)]
    [InlineData(0f, 6.285715f, -1)]
    [InlineData(50f, 177.71428571428572f, -1)]
    [InlineData(100f, 349.14285714285717f, -1)]
    [InlineData(500f, 1720.5714285714287f, -1)]
    [InlineData(1000f, 3434.8571428571427f, -1)]
    [InlineData(-1000f, -3422f, 0)]
    [InlineData(0f, 6f, 0)]
    [InlineData(50f, 178f, 0)]
    [InlineData(100f, 349f, 0)]
    [InlineData(500f, 1721f, 0)]
    [InlineData(1000f, 3435f, 0)]
    [InlineData(-1000f, -3422.3f, 1)]
    [InlineData(0f, 6.29f, 2)]
    [InlineData(50f, 177.7f, 1)]
    [InlineData(100f, 349.1f, 1)]
    [InlineData(500f, 1720.571428571429f, 14)]
    [InlineData(1000f, 3434.86f, 2)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000f, -3422.285714285714f, -1)]
    [InlineData(0f, 6.285715f, -1)]
    [InlineData(50f, 177.71428571428572f, -1)]
    [InlineData(100f, 349.14285714285717f, -1)]
    [InlineData(500f, 1720.5714285714287f, -1)]
    [InlineData(1000f, 3434.8571428571427f, -1)]
    [InlineData(-1000f, -3422f, 0)]
    [InlineData(0f, 6f, 0)]
    [InlineData(50f, 178f, 0)]
    [InlineData(100f, 349f, 0)]
    [InlineData(500f, 1721f, 0)]
    [InlineData(1000f, 3435f, 0)]
    [InlineData(-1000f, -3422.3f, 1)]
    [InlineData(0f, 6.29f, 2)]
    [InlineData(50f, 177.7f, 1)]
    [InlineData(100f, 349.1f, 1)]
    [InlineData(500f, 1720.571428571429f, 14)]
    [InlineData(1000f, 3434.86f, 2)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rømer
}
