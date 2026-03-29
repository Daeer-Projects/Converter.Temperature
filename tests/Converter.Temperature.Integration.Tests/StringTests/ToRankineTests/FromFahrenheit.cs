using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRankineTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_string_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.6700000000001";
        const string input = "392";

        // Act.
        string result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.6700000000001";
        const string input = "392";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("851.6700000000001", -1)]
    [InlineData("852", 0)]
    [InlineData("851.7", 1)]
    public void Test_string_extensions_with_parameter_from_fahrenheit_to_rankine_returns_correct_value(
        string expected,
        int fractionalCount)
    {
        // Arrange.
        const string input = "392";

        // Act.
        string result = input.FromFahrenheit()
            .ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("851.6700000000001", -1)]
    [InlineData("852", 0)]
    [InlineData("851.7", 1)]
    public void Test_string_extensions_generic_with_parameter_from_fahrenheit_to_rankine_returns_correct_value(
        string expected,
        int fractionalCount)
    {
        // Arrange.
        const string input = "392";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
