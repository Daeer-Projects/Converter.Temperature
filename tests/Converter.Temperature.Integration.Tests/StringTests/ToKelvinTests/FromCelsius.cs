using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToKelvinTests;

public class FromCelsius
{
    [Fact]
    public void Test_string_extensions_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        const string input = "200";

        // Act.
        string result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        const string input = "200";

        // Act.
        string result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        double input)
    {

        // Arrange.
        // Act.
        string result = input
            .ToString(CultureInfo.InvariantCulture)
            .FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .NotBeNullOrEmpty();
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        double input)
    {

        // Arrange.
        // Act.
        string result = input
            .ToString(CultureInfo.InvariantCulture)
            .From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .NotBeNullOrEmpty();
    }
}
