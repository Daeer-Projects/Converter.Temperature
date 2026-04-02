using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToCelsiusTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300d, -100d)]
    [InlineData(150d, 0d)]
    [InlineData(0d, 100d)]
    public void Test_double_extensions_from_delisle_to_celsius_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromDelisle()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(300d, -100d)]
    [InlineData(150d, 0d)]
    [InlineData(0d, 100d)]
    public void Test_double_extensions_generic_from_delisle_to_celsius_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Delisle>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
    [Fact]
    public void Test_delisle_to_celsius_overflow_throws_exception()
    {
        // Arrange
        const double input = double.MinValue;

        // Act
        Func<double> action = () => input.FromDelisle().ToCelsius();

        // Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Test_delisle_to_celsius_underflow_throws_exception()
    {
        // Arrange
        const double input = double.MaxValue;

        // Act
        Func<double> action = () => input.FromDelisle().ToCelsius();

        // Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }
}
