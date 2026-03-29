using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToCelsiusTests;

public class FromKelvin
{
    [Fact]
    public void Test_string_extensions_from_kelvin_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "1";
        const string input = "274.15";

        // Act.
        string result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_kelvin_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "1";
        const string input = "274.15";

        // Act.
        string result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_string_value()
    {
        // Arrange.
        string expected = double.MinValue.ToString(CultureInfo.InvariantCulture);
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        string result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_string_value()
    {
        // Arrange.
        string expected = double.MinValue.ToString(CultureInfo.InvariantCulture);
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        string result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
