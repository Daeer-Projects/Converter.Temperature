using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRankineTests;

public class FromCelsius
{
    [Fact]
    public void Test_double_extensions_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(851.67d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_with_parameter_from_celsius_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToRankine(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(851.67d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_generic_with_parameter_from_celsius_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Rankine>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
