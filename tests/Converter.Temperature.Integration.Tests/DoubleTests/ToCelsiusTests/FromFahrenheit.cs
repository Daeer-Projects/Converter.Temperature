using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToCelsiusTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_double_extension_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
    {
        // Arrange.
        const double input = double.MinValue;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromFahrenheit()
            .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_double_extension_generic_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
    {
        // Arrange.
        const double input = double.MinValue;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Fahrenheit>()
            .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_double_extensions_from_fahrenheit_to_celsius_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 10d;
        const double input = 50d;

        // Act.
        double result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_fahrenheit_to_celsius_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 10d;
        const double input = 50d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
