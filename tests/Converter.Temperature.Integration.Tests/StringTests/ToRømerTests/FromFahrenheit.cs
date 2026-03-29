using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRømerTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_string_extension_from_fahrenheit_to_rømer_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "392";

        // Act.
        string result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_fahrenheit_to_rømer_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "392";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_string_extension_with_parameter_from_fahrenheit_to_rømer_returns_correct_string_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "392.94";

        // Act.
        string result = input.FromFahrenheit()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_string_extension_generic_with_parameter_from_fahrenheit_to_rømer_returns_correct_string_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "392.94";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }
}
