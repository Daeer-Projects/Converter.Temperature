using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToFahrenheitTests;

public class FromCelsius
{
        [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        double input)
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
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void
        Test_double_extension_generic_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
            double input)
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
    [InlineData(-152436784.334563d, -274386179.8022134d)]
    [InlineData(0.0d, 32.0d)]
    [InlineData(26431662.73648262d, 47577024.925668716d)]
    public void Test_double_extension_from_celsius_and_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-152436784.334563d, -274386179.8022134d)]
    [InlineData(0.0d, 32.0d)]
    [InlineData(26431662.73648262d, 47577024.925668716d)]
    public void Test_double_extension_generic_from_celsius_and_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Celsius>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-152436784.334563d, -274386179.8022134d, -1)]
    [InlineData(0.0d, 32.0d, -1)]
    [InlineData(26431662.73648262d, 47577024.925668716d, -1)]
    [InlineData(-152436784.334563d, -274386180d, 0)]
    [InlineData(0.0d, 32d, 0)]
    [InlineData(26431662.73648262d, 47577025d, 0)]
    [InlineData(-152436784.334563d, -274386179.802d, 3)]
    [InlineData(0.0d, 32.0d, 1)]
    [InlineData(26431662.73648262d, 47577024.92567d, 5)]
    public void Test_double_extension_with_parameter_from_celsius_and_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-152436784.334563d, -274386179.8022134d, -1)]
    [InlineData(0.0d, 32.0d, -1)]
    [InlineData(26431662.73648262d, 47577024.925668716d, -1)]
    [InlineData(-152436784.334563d, -274386180d, 0)]
    [InlineData(0.0d, 32d, 0)]
    [InlineData(26431662.73648262d, 47577025d, 0)]
    [InlineData(-152436784.334563d, -274386179.802d, 3)]
    [InlineData(0.0d, 32.0d, 1)]
    [InlineData(26431662.73648262d, 47577024.92567d, 5)]
    public void
        Test_double_extension_generic_with_parameter_from_celsius_and_to_fahrenheit_returns_correct_double_value(
            double input,
            double expected,
            int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = input.From<Celsius>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
