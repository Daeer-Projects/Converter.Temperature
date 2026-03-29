using System;
using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToCelsiusTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_string_extension_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
    {
        // Arrange.
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromFahrenheit()
            .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_string_extension_generic_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
    {
        // Arrange.
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Fahrenheit>()
            .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_string_extensions_from_fahrenheit_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "10";
        const string input = "50";

        // Act.
        string result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_fahrenheit_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "10";
        const string input = "50";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
