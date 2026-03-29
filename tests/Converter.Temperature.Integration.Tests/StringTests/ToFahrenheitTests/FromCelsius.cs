using System;
using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToFahrenheitTests;

public class FromCelsius
{
    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        double input)
    {

        // Arrange.
        // Act.
        Action action = () => input
            .ToString(CultureInfo.InvariantCulture)
            .FromCelsius()
            .ToFahrenheit();

        // Assert.
        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("*Value out of range for type.*");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void
        Test_string_extension_generic_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
            double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input
            .ToString(CultureInfo.InvariantCulture)
            .From<Celsius>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData("-152436784.334563", "-274386179.8022134")]
    [InlineData("0.0", "32")]
    [InlineData("26431662.73648262", "47577024.92566872")]
    public void Test_string_extension_from_celsius_and_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromCelsius()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-152436784.334563", "-274386179.8022134")]
    [InlineData("0.0", "32")]
    [InlineData("26431662.73648262", "47577024.92566872")]
    public void Test_string_extension_generic_from_celsius_and_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Celsius>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-152436784.334563", "-274386179.8022134", -1)]
    [InlineData("0.0", "32", -1)]
    [InlineData("26431662.73648262", "47577024.92566872", -1)]
    [InlineData("-152436784.334563", "-274386180", 0)]
    [InlineData("0.0", "32", 0)]
    [InlineData("26431662.73648262", "47577025", 0)]
    [InlineData("-152436784.334563", "-274386179.802", 3)]
    [InlineData("26431662.73648262", "47577024.92567", 5)]
    public void Test_string_extension_with_parameter_from_celsius_and_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = input.FromCelsius()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-152436784.334563", "-274386179.8022134", -1)]
    [InlineData("0.0", "32", -1)]
    [InlineData("26431662.73648262", "47577024.92566872", -1)]
    [InlineData("-152436784.334563", "-274386180", 0)]
    [InlineData("0.0", "32", 0)]
    [InlineData("26431662.73648262", "47577025", 0)]
    [InlineData("-152436784.334563", "-274386179.802", 3)]
    [InlineData("26431662.73648262", "47577024.92567", 5)]
    public void
        Test_string_extension_generic_with_parameter_from_celsius_and_to_fahrenheit_returns_correct_string_value(
            string input,
            string expected,
            int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = input.From<Celsius>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
