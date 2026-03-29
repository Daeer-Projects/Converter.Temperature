using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRømerTests;

public class FromCelsius
{
    [Fact]
    public void Test_string_extension_from_celsius_to_rømer_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "200";

        // Act.
        string result = input.FromCelsius()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_celsius_to_rømer_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "200";

        // Act.
        string result = input.From<Celsius>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.08d, 2)]
    public void Test_string_extension_with_parameter_from_celsius_to_rømer_returns_correct_string_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "203";

        // Act.
        string result = input.FromCelsius()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.08d, 2)]
    public void Test_string_extension_generic_with_parameter_from_celsius_to_rømer_returns_correct_string_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "203";

        // Act.
        string result = input.From<Celsius>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }
}
