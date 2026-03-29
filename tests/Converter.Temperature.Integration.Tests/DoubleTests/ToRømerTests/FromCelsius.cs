using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRømerTests;

public class FromCelsius
{
    [Fact]
    public void Test_double_extension_from_celsius_to_rømer_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 112.5d;
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extension_generic_from_celsius_to_rømer_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 112.5d;
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.08d, 2)]
    public void Test_double_extension_with_parameter_from_celsius_to_rømer_returns_correct_double_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 203d;

        // Act.
        double result = input.FromCelsius()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.08d, 2)]
    public void Test_double_extension_generic_with_parameter_from_celsius_to_rømer_returns_correct_double_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 203d;

        // Act.
        double result = input.From<Celsius>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        double input)
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
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_generic_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        double input)
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
