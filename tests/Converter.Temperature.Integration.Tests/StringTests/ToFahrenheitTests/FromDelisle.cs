using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToFahrenheitTests;

public class FromDelisle
{
    [Theory]
    [InlineData("300", "-148")]
    [InlineData("150", "32")]
    [InlineData("0", "212")]
    public void Test_string_extensions_from_delisle_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromDelisle()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("300", "-148")]
    [InlineData("150", "32")]
    [InlineData("0", "212")]
    public void Test_string_extensions_generic_from_delisle_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Delisle>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
