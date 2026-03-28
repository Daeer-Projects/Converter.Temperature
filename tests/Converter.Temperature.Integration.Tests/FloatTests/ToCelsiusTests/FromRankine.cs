using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToCelsiusTests;

public class FromRankine
{
    [Theory]
    [InlineData(0f, -273.15002f)]
    [InlineData(-100f, -328.70557f)]
    [InlineData(100f, -217.59445f)]
    [InlineData(1000f, 282.40555f)]
    public void Test_float_extension_from_rankine_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRankine()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0f, -273.15002f)]
    [InlineData(-100f, -328.70557f)]
    [InlineData(100f, -217.59445f)]
    [InlineData(1000f, 282.40555f)]
    public void Test_float_extension_generic_from_rankine_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Rankine>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0f, -273.15002f, -1)]
    [InlineData(-100f, -328.70557f, -1)]
    [InlineData(-100f, -328.7f, 1)]
    [InlineData(-100f, -328.7056f, 4)]
    [InlineData(100f, -217.59445f, -1)]
    [InlineData(100f, -217.6f, 1)]
    [InlineData(100f, -217.594f, 3)]
    [InlineData(1000f, 282.40555f, -1)]
    [InlineData(1000f, 282.4f, 1)]
    [InlineData(1000f, 282.41f, 2)]
    public void Test_float_extension_from_rankine_with_parameter_to_celsius_returns_correct_float_value(
        float input,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = input.FromRankine()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0f, -273.15002f, -1)]
    [InlineData(-100f, -328.70557f, -1)]
    [InlineData(-100f, -328.7f, 1)]
    [InlineData(-100f, -328.7056f, 4)]
    [InlineData(100f, -217.59445f, -1)]
    [InlineData(100f, -217.6f, 1)]
    [InlineData(100f, -217.594f, 3)]
    [InlineData(1000f, 282.40555f, -1)]
    [InlineData(1000f, 282.4f, 1)]
    [InlineData(1000f, 282.41f, 2)]
    public void Test_float_extension_generic_from_rankine_with_parameter_to_celsius_returns_correct_float_value(
        float input,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = input.From<Rankine>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_rankine_to_celsius_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_generic_from_rankine_to_celsius_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
