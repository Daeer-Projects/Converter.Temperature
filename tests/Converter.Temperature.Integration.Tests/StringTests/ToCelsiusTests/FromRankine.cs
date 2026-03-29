using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToCelsiusTests;

public class FromRankine
{
    [Theory]
    [InlineData(0, -273.15d)]
    [InlineData(50, -245.3722222222222d)]
    [InlineData(100, -217.59444444444446d)]
    [InlineData(500, 4.627777777777769d)]
    [InlineData(1000, 282.40555555555557d)]
    public void Test_string_extension_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0, -273.15d)]
    [InlineData(50, -245.3722222222222d)]
    [InlineData(100, -217.59444444444446d)]
    [InlineData(500, 4.627777777777769d)]
    [InlineData(1000, 282.40555555555557d)]
    public void Test_string_extension_generic_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0, -273.15d, -1)]
    [InlineData(50, -245.3722222222222d, -1)]
    [InlineData(100, -217.59444444444446d, -1)]
    [InlineData(500, 4.627777777777769d, -1)]
    [InlineData(1000, 282.40555555555557d, -1)]
    public void Test_string_extension_with_parameter_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0, -273.15d, -1)]
    [InlineData(50, -245.3722222222222d, -1)]
    [InlineData(100, -217.59444444444446d, -1)]
    [InlineData(500, 4.627777777777769d, -1)]
    [InlineData(1000, 282.40555555555557d, -1)]
    public void Test_string_extension_generic_with_parameter_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }
}
