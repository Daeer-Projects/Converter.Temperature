using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToCelsiusTests;

public class FromCelsius
{
    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_from_and_to_celsius_returns_correct_string_value(
        double value)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromCelsius()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(value.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_generic_from_and_to_celsius_returns_correct_string_value(
        double value)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Celsius>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(value.ToString(CultureInfo.InvariantCulture));
    }
}
