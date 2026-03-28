using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRømerTests;

public class FromCelsius
{
        [Fact]
    public void Test_float_extension_from_celsius_to_rømer_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 200f;

        // Act.
        float result = input.FromCelsius()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extension_generic_from_celsius_to_rømer_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 200f;

        // Act.
        float result = input.From<Celsius>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.07d, 2)]
    public void Test_float_extension_with_parameter_from_celsius_to_rømer_returns_correct_float_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 203f;

        // Act.
        float result = input.FromCelsius()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.07d, 2)]
    public void Test_float_extension_generic_with_parameter_from_celsius_to_rømer_returns_correct_float_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 203f;

        // Act.
        float result = input.From<Celsius>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToRømer());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_generic_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Rømer>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
