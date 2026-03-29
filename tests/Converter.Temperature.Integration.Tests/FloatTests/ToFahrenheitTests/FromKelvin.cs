using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToFahrenheitTests;

public class FromKelvin
{
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
            .BeApproximately(expected, 1e-4f);
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
            .BeApproximately(expected, 1e-4f);
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
            .BeApproximately(expected, 1e-4f);
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
            .BeApproximately(expected, 1e-4f);
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
}
